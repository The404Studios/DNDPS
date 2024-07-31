using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using DarkAndDarker.Cryptography.Sequence.Common;
using DC.Packet;
using System.Reflection;

namespace YourNamespace
{
    public class FriendService
    {
        private static Random random = new Random();

        public static Tuple<SCHARACTER_FRIEND_INFO, int, int> CountFriends()
        {
            int inLobby = 0;
            int inDungeon = 0;

            foreach (var user in sessions.Values)
            {
                if (user.character == null)
                    continue;

                var nickname = new SACCOUNT_NICKNAME
                {
                    originalNickName = user.character.nickname,
                    streamingModeNickName = user.character.streaming_nickname
                };

                var friendInfo = new SCHARACTER_FRIEND_INFO
                {
                    accountId = user.account.id.ToString(),
                    nickName = { originalNickName = nickname.originalNickName, streamingModeNickName = nickname.streamingModeNickName },
                    characterClass = (int)Enum.Parse(typeof(CharacterClass), user.character.character_class),
                    characterId = user.character.id.ToString(),
                    gender = (int)Enum.Parse(typeof(Gender), user.character.gender),
                    level = user.character.level
                };

                var isSolo = user.party.players.Count <= 1;
                var location = user.state.location == Define_Common.MetaLocation.INGAME
                    ? Friend_Location.Friend_Location_DUNGEON
                    : Friend_Location.Friend_Location_LOBBY;

                friendInfo.locationStatus = location;
                friendInfo.PartyMemeberCount = isSolo ? 0 : user.party.players.Count;
                friendInfo.PartyMaxMemeberCount = isSolo ? 0 : 3;

                if (location == Friend_Location.Friend_Location_DUNGEON)
                    inDungeon++;
                else
                    inLobby++;
            }

            return Tuple.Create(friendInfo, inLobby, inDungeon);
        }

        public static SS2C_FRIEND_LIST_ALL_RES ListFriends(Context ctx, byte[] msg)
        {
            ctx.Reply(new SS2C_FRIEND_LIST_ALL_RES { loopFlag = Define_Message.LoopFlag.BEGIN });

            var res = new SS2C_FRIEND_LIST_ALL_RES
            {
                loopFlag = Define_Message.LoopFlag.PROGRESS
            };

            var (friendInfo, inLobby, inDungeon) = CountFriends();
            res.totalUserCount = res.friendInfoList.Count;
            res.friendInfoList.Add(friendInfo);
            ctx.Reply(res);

            return new SS2C_FRIEND_LIST_ALL_RES
            {
                loopFlag = Define_Message.LoopFlag.END,
                lobbyLocateCount = inLobby,
                dungeonLocateCount = inDungeon
            };
        }

        public static SS2C_FRIEND_FIND_RES FindUser(Context ctx, byte[] msg)
        {
            var req = SC2S_FRIEND_FIND_REQ.Parser.ParseFrom(msg);

            var res = new SS2C_FRIEND_FIND_RES { result = PacketCommand.SUCCESS };

            if (string.IsNullOrEmpty(req.nickName.originalNickName))
                return res;

            var currentCharacter = sessions[ctx.Transport].character;
            if (req.nickName.originalNickName == currentCharacter.nickname)
                return res;

            var (_, session) = GetUser(nickname: req.nickName.originalNickName);
            if (session != null)
            {
                var isSolo = session.party.players.Count <= 1;
                var location = session.state.location == Define_Common.MetaLocation.INGAME
                    ? Friend_Location.Friend_Location_DUNGEON
                    : Friend_Location.Friend_Location_LOBBY;

                var friend = new SCHARACTER_FRIEND_INFO
                {
                    accountId = session.account.id.ToString(),
                    nickName = { originalNickName = session.character.nickname, streamingModeNickName = session.character.streaming_nickname },
                    characterClass = (int)Enum.Parse(typeof(CharacterClass), session.character.character_class),
                    characterId = session.character.id.ToString(),
                    gender = (int)Enum.Parse(typeof(Gender), session.character.gender),
                    level = session.character.level,
                    locationStatus = location,
                    PartyMemeberCount = isSolo ? 0 : session.party.players.Count,
                    PartyMaxMemeberCount = isSolo ? 0 : 3
                };
                res.friendInfo = friend;
            }

            return res;
        }

        public static SS2C_BLOCK_CHARACTER_RES BlockUser(Context ctx, byte[] msg)
        {
            var req = SC2S_BLOCK_CHARACTER_REQ.Parser.ParseFrom(msg);

            var blocker = sessions[ctx.Transport];
            var blockedChar = db.Query<Character>().FirstOrDefault(c => c.id == req.targetCharacterId && c.account_id == req.targetAccountId);
            if (blockedChar == null)
                return new SS2C_BLOCK_CHARACTER_RES { result = PacketCommand.FAIL_BLOCK_CHARACTER_NOT_FOUND };

            var dupe = db.Query<BlockedUser>().FirstOrDefault(bu => bu.blocked_by == blocker.character.id && bu.account_id == blockedChar.account_id);
            if (dupe != null)
                return new SS2C_BLOCK_CHARACTER_RES { result = PacketCommand.FAIL_BLOCK_CHARACTER_ALREADY };

            var blocks = db.Query<BlockedUser>().Count(bu => bu.blocked_by == blocker.character.id);
            if (blocks >= config.game.settings.max_blocked_characters)
                return new SS2C_BLOCK_CHARACTER_RES { result = PacketCommand.FAIL_BLOCK_CHARACTER_LIMIT };

            var user = new BlockedUser
            {
                blocked_by = blocker.character.id,
                account_id = blockedChar.account_id,
                character_id = blockedChar.id,
                nickname = blockedChar.nickname,
                character_class = (int)Enum.Parse(typeof(CharacterClass), blockedChar.character_class),
                gender = (int)Enum.Parse(typeof(Gender), blockedChar.gender)
            };
            user.Save();

            var targetCharacterInfo = new SBLOCK_CHARACTER
            {
                accountId = blockedChar.account_id.ToString(),
                characterId = blockedChar.id.ToString(),
                nickName = { originalNickName = blockedChar.nickname, streamingModeNickName = blockedChar.streaming_nickname, karmaRating = blockedChar.karma_rating },
                characterClass = (int)Enum.Parse(typeof(CharacterClass), blockedChar.character_class),
                gender = (int)Enum.Parse(typeof(Gender), blockedChar.gender)
            };

            return new SS2C_BLOCK_CHARACTER_RES
            {
                result = PacketCommand.SUCCESS,
                targetCharacterInfo = targetCharacterInfo
            };
        }

        public static SS2C_UNBLOCK_CHARACTER_RES UnblockUser(Context ctx, byte[] msg)
        {
            var req = SC2S_UNBLOCK_CHARACTER_REQ.Parser.ParseFrom(msg);

            var blocker = sessions[ctx.Transport];
            var blockedChar = db.Query<Character>().FirstOrDefault(c => c.id == req.targetCharacterId && c.account_id == req.targetAccountId);
            if (blockedChar == null)
                return new SS2C_UNBLOCK_CHARACTER_RES { result = PacketCommand.FAIL_BLOCK_CHARACTER_NOT_FOUND };

            var blockedUser = db.Query<BlockedUser>().FirstOrDefault(bu => bu.blocked_by == blocker.character.id && bu.character_id == req.targetCharacterId);
            if (blockedUser != null)
            {
                db.Delete(blockedUser);
            }

            return new SS2C_UNBLOCK_CHARACTER_RES
            {
                result = PacketCommand.SUCCESS,
                targetCharacterId = req.targetCharacterId
            };
        }

        public static SS2C_BLOCK_CHARACTER_LIST_RES GetBlockedUsers(Context ctx, byte[] msg)
        {
            var req = SC2S_BLOCK_CHARACTER_LIST_REQ.Parser.ParseFrom(msg);

            var res = new SS2C_BLOCK_CHARACTER_LIST_RES();

            var query = db.Query<BlockedUser>().Where(bu => bu.account_id == sessions[ctx.Transport].account.id).ToList();
            if (!query.Any())
                return res;

            foreach (var block in query)
            {
                var charBlock = db.Query<Character>().FirstOrDefault(c => c.id == block.character_id);
                if (charBlock != null)
                {
                    res.blockCharacters.Add(new SBLOCK_CHARACTER
                    {
                        accountId = block.account_id.ToString(),
                        characterId = block.character_id.ToString(),
                        nickName = { originalNickName = block.nickname, streamingModeNickName = charBlock.streaming_nickname, karmaRating = charBlock.karma_rating },
                        characterClass = (int)Enum.Parse(typeof(CharacterClass), block.character_class),
                        gender = (int)Enum.Parse(typeof(Gender), block.gender)
                    });
                }
            }

            return res;
        }
    }
}
