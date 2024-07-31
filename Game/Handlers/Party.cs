using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using DarkAndDarker.Cryptography.Chat;
using DC.Packet;
using Google.Protobuf;

namespace SVERA.Services
{
    public static class PartyService
    {
        public static bool HasOnlinePlayers(Party party, List<User> exclude = null)
        {
            exclude ??= new List<User>();
            return party.Players.Any(player => !exclude.Contains(player) && player.State.Location != Define_Common.MetaLocation.OFFLINE);
        }

        public static Party SearchForOldParty(int accountId)
        {
            foreach (var session in Sessions.Values)
            {
                if (session.Party == null || session.Party.Players.Count <= 1 || session.Party.Leader != session)
                    continue;

                if (session.Party.Players.Any(player => player.Account.Id == accountId))
                    return session.Party;
            }
            return null;
        }

        public static void Cleanup(SessionContext ctx)
        {
            var session = Sessions[ctx.Transport];

            if (session.Account == null || session.State == null || session.Party == null || session.Party.Players.Count <= 1)
                return;

            if (!HasOnlinePlayers(session.Party, new List<User> { session }))
                return;

            session.State.Location = Define_Common.MetaLocation.OFFLINE;
            SendPartyLocationNotification(session.Party, session);

            if (session.Party.Leader == session)
            {
                var newLeader = session.Party.Players.FirstOrDefault(user => user != session && user.State.Location != Define_Common.MetaLocation.OFFLINE);
                if (newLeader != null)
                    session.Party.Leader = newLeader;
            }

            SendPartyInfoNotification(session.Party);
        }

        public static SS2C_PARTY_INVITE_RES PartyInvite(SessionContext ctx, byte[] msg)
        {
            var req = SC2S_PARTY_INVITE_REQ.Parser.ParseFrom(msg);
            var party = GetParty(int.Parse(req.FindAccountId));

            if (party.Players.Any(player => Sessions[ctx.Transport].Account.Id == player.Account.Id))
                return new SS2C_PARTY_INVITE_RES { Result = PacketCommand.FAIL_PARTY_INVITE_ALREADY_PARTY };

            SendInviteNotification(ctx, req);
            return new SS2C_PARTY_INVITE_RES { Result = PacketCommand.SUCCESS };
        }

        public static SS2C_PARTY_INVITE_ANSWER_RES AcceptInvite(SessionContext ctx, byte[] msg)
        {
            var req = SC2S_PARTY_INVITE_ANSWER_REQ.Parser.ParseFrom(msg);
            var party = GetParty(int.Parse(req.ReturnAccountId));

            if (party.Players.Any(player => Sessions[ctx.Transport].Account.Id == player.Account.Id))
                return new SS2C_PARTY_INVITE_ANSWER_RES { Result = PacketCommand.SUCCESS };

            SendAcceptNotification(ctx, req);

            if (req.InviteResult != PacketCommand.SUCCESS)
                return new SS2C_PARTY_INVITE_ANSWER_RES { Result = PacketCommand.SUCCESS };

            var leavingSession = Sessions[ctx.Transport];
            if (leavingSession.Party.Players.Count == 1)
                Sessions[ctx.Transport].Party = null;

            party.AddMember(leavingSession);
            Sessions[ctx.Transport].Party = party;

            SendPartyInfoNotification(party);

            foreach (var user in party.Players)
                SendPartyLocationNotification(party, user);

            return new SS2C_PARTY_INVITE_ANSWER_RES { Result = PacketCommand.SUCCESS };
        }

        public static void SendInviteNotification(SessionContext ctx, SC2S_PARTY_INVITE_REQ req)
        {
            var notify = new SS2C_PARTY_INVITE_NOT
            {
                InviteeNickName = new SACCOUNT_NICKNAME
                {
                    OriginalNickName = Sessions[ctx.Transport].Character.Nickname,
                    StreamingModeNickName = Sessions[ctx.Transport].Character.StreamingNickname,
                    KarmaRating = Sessions[ctx.Transport].Character.KarmaRating
                },
                InviteeAccountId = Sessions[ctx.Transport].Account.Id.ToString(),
                InviteeCharacterId = Sessions[ctx.Transport].Character.Id.ToString()
            };

            var header = MakeHeader(notify);
            var transport = GetUser(req.FindNickName.OriginalNickName)?.Transport;
            transport?.Write(header + notify.ToByteArray());
        }

        public static void SendAcceptNotification(SessionContext ctx, SC2S_PARTY_INVITE_ANSWER_REQ req)
        {
            var transport = GetUser(int.Parse(req.ReturnAccountId))?.Transport;
            if (transport == null)
                return;

            var notify = new SS2C_PARTY_INVITE_ANSWER_RESULT_NOT
            {
                NickName = new SACCOUNT_NICKNAME
                {
                    OriginalNickName = Sessions[ctx.Transport].Character.Nickname,
                    StreamingModeNickName = Sessions[ctx.Transport].Character.StreamingNickname,
                    KarmaRating = Sessions[ctx.Transport].Character.KarmaRating
                },
                InviteResult = req.InviteResult
            };

            var header = MakeHeader(notify);
            transport.Write(header + notify.ToByteArray());
        }

        public static void SendPartyInfoNotification(Party party)
        {
            var notify = new SS2C_PARTY_MEMBER_INFO_NOT();
            foreach (var user in party.Players)
            {
                var nick = new SACCOUNT_NICKNAME
                {
                    OriginalNickName = user.Character.Nickname,
                    StreamingModeNickName = user.Character.StreamingNickname,
                    KarmaRating = user.Character.KarmaRating
                };

                var info = new SCHARACTER_PARTY_INFO
                {
                    AccountId = user.Account.Id.ToString(),
                    NickName = { OriginalNickName = nick.OriginalNickName, StreamingModeNickName = nick.StreamingModeNickName, KarmaRating = nick.KarmaRating },
                    CharacterClass = (int)user.Character.CharacterClass,
                    CharacterId = user.Character.Id.ToString(),
                    Gender = (int)user.Character.Gender,
                    Level = user.Character.Level,
                    IsPartyLeader = party.Leader == user,
                    IsReady = user.State.IsReady,
                    IsInGame = user.State.Location == Define_Common.MetaLocation.INGAME,
                    EquipItemList = { inventory.GetAllItems(user.Character.Id, Define_Item.InventoryId.EQUIPMENT).Select(i => Char.ItemToProtoItem(i.Item, i.Attribute)) },
                    PartyIdx = party.Id
                };

                notify.PlayPartyUserInfoData.Add(info);
            }

            var header = MakeHeader(notify);
            foreach (var user in party.Players)
            {
                var transport = GetUser(user.Account.Id)?.Transport;
                transport?.Write(header + notify.ToByteArray());
            }
        }

        public static void SendPartyLocationNotification(Party party, User session)
        {
            var notify = new SS2C_PARTY_LOCATION_UPDATE_NOT
            {
                AccountId = session.Account.Id.ToString(),
                CharacterId = session.Character.Id.ToString(),
                UpdateLocation = (int)session.State.Location
            };

            var header = MakeHeader(notify);
            foreach (var user in party.Players.Where(user => user.Account.Id != session.Account.Id))
            {
                var transport = GetUser(user.Account.Id)?.Transport;
                transport?.Write(header + notify.ToByteArray());
            }
        }

        public static SS2C_PARTY_EXIT_RES LeaveParty(SessionContext ctx, byte[] msg)
        {
            var req = SC2S_PARTY_EXIT_REQ.Parser.ParseFrom(msg);
            var userLeaving = Sessions[ctx.Transport];

            if (userLeaving.Party == null)
                return new SS2C_PARTY_EXIT_RES { Result = PacketCommand.FAIL_GENERAL };

            if (userLeaving.Party.Leader == userLeaving)
            {
                var newLeader = userLeaving.Party.Players.FirstOrDefault(user => user != userLeaving && user.State.Location != Define_Common.MetaLocation.OFFLINE);
                if (newLeader != null)
                    userLeaving.Party.Leader = newLeader;
            }

            userLeaving.Party.RemoveMember(userLeaving);
            SendPartyInfoNotification(userLeaving.Party);

            var newParty = new Party { Player1 = userLeaving };
            userLeaving.Party = newParty;
            SendPartyInfoNotification(newParty);

            return new SS2C_PARTY_EXIT_RES { Result = PacketCommand.SUCCESS };
        }

        public static SS2C_PARTY_READY_RES SetReadyState(SessionContext ctx, byte[] msg)
        {
            var req = SC2S_PARTY_READY_REQ.Parser.ParseFrom(msg);
            Sessions[ctx.Transport].State.IsReady = req.IsReady;
            SendPartyInfoNotification(Sessions[ctx.Transport].Party);
            return new SS2C_PARTY_READY_RES { Result = PacketCommand.SUCCESS };
        }

        public static SS2C_PARTY_MEMBER_KICK_RES KickMember(SessionContext ctx, byte[] msg)
        {
            var req = SC2S_PARTY_MEMBER_KICK_REQ.Parser.ParseFrom(msg);
            var party = Sessions[ctx.Transport].Party;

            if (party.Leader != Sessions[ctx.Transport])
                return new SS2C_PARTY_MEMBER_KICK_RES { Result = PacketCommand.FAIL_GENERAL };

            var kickedUser = party.Players.FirstOrDefault(player => player.Account.Id.ToString() == req.AccountId);
            if (kickedUser == null)
                return new SS2C_PARTY_MEMBER_KICK_RES { Result = PacketCommand.FAIL_GENERAL };

            party.RemoveMember(kickedUser);

            if (kickedUser.State.Location != Define_Common.MetaLocation.OFFLINE)
            {
                var newParty = new Party { Player1 = kickedUser, Leader = kickedUser };
                kickedUser.Party = newParty;
                SendPartyInfoNotification(newParty);
            }

            SendPartyInfoNotification(party);
            return new SS2C_PARTY_MEMBER_KICK_RES { Result = PacketCommand.SUCCESS };
        }

        public static void BroadcastChat(SessionContext ctx, byte[] msg)
        {
            var res = new SS2C_PARTY_CHAT_NOT
            {
                ChatData = ByteString.CopyFrom(msg),
                Time = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
            };

            var header = MakeHeader(res);
            foreach (var user in Sessions[ctx.Transport].Party.Players)
            {
                var transport = GetUser(user.Account.Id)?.Transport;
                transport?.Write(header + res.ToByteArray());
            }
        }

        public static SS2C_PARTY_CHAT_RES Chat(SessionContext ctx, byte[] msg)
        {
            var req = SC2S_PARTY_CHAT_REQ.Parser.ParseFrom(msg);
            var character = Sessions[ctx.Transport].Character;
            var chatStr = req.ChatData.ChatDataPieceArray[0].ChatStr;

            var chatPiece = new SCHATDATA_PIECE { ChatStr = chatStr };
            var nickName = new SACCOUNT_NICKNAME
            {
                OriginalNickName = character.Nickname,
                StreamingModeNickName = character.StreamingNickname
            };

            var chatData = new SCHATDATA
            {
                AccountId = Sessions[ctx.Transport].Account.Id.ToString(),
                CharacterId = character.Id.ToString(),
                Nickname = { CopyFrom(nickName) },
                PartyId = Sessions[ctx.Transport].Party.Id.ToString()
            };
            chatData.ChatDataPieceArray.Add(chatPiece);

            BroadcastChat(ctx, chatData.ToByteArray());

            return new SS2C_PARTY_CHAT_RES { Result = 1 };
        }
    }
}

