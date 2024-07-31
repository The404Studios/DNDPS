using DC.Packet;
using DndServer.Objects;

namespace SVERA.Services
{
    public static class LobbyService
    {
        public static SS2C_LOBBY_ENTER_RES EnterLobby(Context ctx, byte[] msg)
        {
            var req = SC2S_LOBBY_ENTER_REQ.Parser.ParseFrom(msg);
            var query = DatabaseContext.Instance.Characters.FirstOrDefault(c => c.Id == req.CharacterId);

            if (query == null)
            {
                // Handle character not found case
                return new SS2C_LOBBY_ENTER_RES
                {
                    Result = PacketCommand.SUCCESS,
                    AccountId = string.Empty // or handle accordingly
                };
            }

            var res = new SS2C_LOBBY_ENTER_RES
            {
                Result = PacketCommand.SUCCESS,
                AccountId = query.Id.ToString()
            };

            // Update session
            SessionManager.Sessions[ctx.Transport].Character = query;
            SessionManager.Sessions[ctx.Transport].State = new State();

            // Check if we need to create or update a party
            var session = SessionManager.Sessions[ctx.Transport];

            if (session.Party != null)
            {
                if (session.Party.Players.Count > 1 && PartyHandler.HasOnlinePlayers(session.Party, new[] { session }))
                {
                    PartyHandler.SendPartyInfoNotification(session.Party);
                }
            }
            else
            {
                var oldParty = PartyHandler.SearchForOldParty(session.Account.Id);

                if (oldParty != null)
                {
                    var playerIndex = oldParty.Players.FindIndex(p => p.Account.Id == session.Account.Id);
                    if (playerIndex >= 0)
                    {
                        oldParty.Players[playerIndex] = session;
                        session.Party = oldParty;
                        PartyHandler.SendPartyInfoNotification(oldParty);
                    }
                }
                else
                {
                    var newParty = new Party(session);
                    session.Party = newParty;
                    PartyHandler.SendPartyInfoNotification(newParty);
                }
            }

            ctx.Reply(CharacterHandler.GetCharacterInfo(ctx, msg));
            return res;
        }

        public static SS2C_LOBBY_REGION_SELECT_RES RegionSelect(Context ctx, byte[] msg)
        {
            var req = SC2S_LOBBY_REGION_SELECT_REQ.Parser.ParseFrom(msg);
            return new SS2C_LOBBY_REGION_SELECT_RES
            {
                Result = PacketCommand.SUCCESS,
                Region = req.Region
            };
        }

        public static SS2C_CHARACTER_SELECT_ENTER_RES Start(Context ctx, byte[] msg)
        {
            var req = SC2S_CHARACTER_SELECT_ENTER_REQ.Parser.ParseFrom(msg);
            return new SS2C_CHARACTER_SELECT_ENTER_RES
            {
                Result = PacketCommand.SUCCESS
            };
        }

        public static SS2C_CHARACTER_SELECT_ENTER_RES EnterCharacterSelect(Context ctx, byte[] msg)
        {
            return new SS2C_CHARACTER_SELECT_ENTER_RES
            {
                Result = 1 // Adjust based on actual implementation
            };
        }

        public static SS2C_LOBBY_GAME_DIFFICULTY_SELECT_RES MapSelect(Context ctx, byte[] msg)
        {
            var req = SC2S_LOBBY_GAME_DIFFICULTY_SELECT_REQ.Parser.ParseFrom(msg);
            return new SS2C_LOBBY_GAME_DIFFICULTY_SELECT_RES
            {
                Result = PacketCommand.SUCCESS,
                GameDifficultyTypeIndex = req.GameDifficultyTypeIndex
            };
        }

        public static SS2C_OPEN_LOBBY_MAP_RES OpenMapSelect(Context ctx, byte[] msg)
        {
            var req = SC2S_OPEN_LOBBY_MAP_REQ.Parser.ParseFrom(msg);
            return new SS2C_OPEN_LOBBY_MAP_RES();
        }
    }
}