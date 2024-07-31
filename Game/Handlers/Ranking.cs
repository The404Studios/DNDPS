using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using DC.Packet;

namespace SVERA.Services
{
    public static class RankingService
    {
        public static SS2C_RANKING_CHARACTER_RES GetCharacterRanking(SessionContext ctx, byte[] msg)
        {
            var req = SC2S_RANKING_CHARACTER_REQ.Parser.ParseFrom(msg);

            var res = new SS2C_RANKING_CHARACTER_RES
            {
                Result = PacketCommand.SUCCESS,
                RankType = req.RankType,
                AllRowCount = 1,
                CharacterClass = req.CharacterClass
            };

            var character = Sessions[ctx.Transport].Character;

            // TODO: Implement actual ranking retrieval logic
            var record = new SRankRecord
            {
                Score = 0,
                Percentage = 0,
                AccountId = character.AccountId.ToString(),
                PageIndex = 0,
                Rank = 0,
                CharacterClass = req.CharacterClass
            };

            var nickname = new SACCOUNT_NICKNAME
            {
                OriginalNickName = character.Nickname,
                StreamingModeNickName = character.StreamingNickname
            };

            record.NickName = nickname;
            res.RankRecord = record;

            return res;
        }

        public static SS2C_RANKING_RANGE_RES GetRanking(SessionContext ctx, byte[] msg)
        {
            var req = SC2S_RANKING_RANGE_REQ.Parser.ParseFrom(msg);
            var query = db.Query<Character>();

            // Filter by character class if specified
            if (req.CharacterClass != (int)CharacterClass.NONE)
            {
                query = query.Where(c => c.CharacterClass == (CharacterClass)req.CharacterClass);
            }

            // Order query based on rank type
            switch (req.RankType)
            {
                case RANKING_TYPE.COIN:
                    query = query.OrderByDescending(c => c.RankingCoin);
                    break;
                case RANKING_TYPE.KILL:
                    query = query.OrderByDescending(c => c.RankingKill);
                    break;
                case RANKING_TYPE.ESCAPE:
                    query = query.OrderByDescending(c => c.RankingEscape);
                    break;
                case RANKING_TYPE.ADVENTURE:
                    query = query.OrderByDescending(c => c.RankingAdventure);
                    break;
                case RANKING_TYPE.BOSSKILL_LICH:
                    query = query.OrderByDescending(c => c.RankingLich);
                    break;
                case RANKING_TYPE.BOSSKILL_GHOSTKING:
                    query = query.OrderByDescending(c => c.RankingGhostKing);
                    break;
                default:
                    return new SS2C_RANKING_RANGE_RES { Result = PacketCommand.FAIL_NO_VALUE };
            }

            var totalRecords = query.Count();
            var records = query.Skip(req.StartIndex).Take(req.EndIndex - req.StartIndex).ToList();

            var res = new SS2C_RANKING_RANGE_RES
            {
                Result = totalRecords > 0 ? PacketCommand.SUCCESS : PacketCommand.FAIL_NO_VALUE,
                RankType = req.RankType,
                StartIndex = req.StartIndex,
                EndIndex = Math.Min(totalRecords, req.EndIndex),
                CharacterClass = req.CharacterClass,
                AllRowCount = totalRecords
            };

            foreach (var character in records)
            {
                int score = 0;
                switch (req.RankType)
                {
                    case RANKING_TYPE.COIN:
                        score = character.RankingCoin;
                        break;
                    case RANKING_TYPE.KILL:
                        score = character.RankingKill;
                        break;
                    case RANKING_TYPE.ESCAPE:
                        score = character.RankingEscape;
                        break;
                    case RANKING_TYPE.ADVENTURE:
                        score = character.RankingAdventure;
                        break;
                    case RANKING_TYPE.BOSSKILL_LICH:
                        score = character.RankingLich;
                        break;
                    case RANKING_TYPE.BOSSKILL_GHOSTKING:
                        score = character.RankingGhostKing;
                        break;
                }

                if (score == 0)
                {
                    // If the score is 0, we don't show it. Exiting early.
                    break;
                }

                var record = new SRankRecord
                {
                    Score = score,
                    Percentage = 1.0,
                    AccountId = character.AccountId.ToString(),
                    PageIndex = records.IndexOf(character),
                    Rank = records.IndexOf(character) + 1,
                    CharacterClass = (int)character.CharacterClass
                };

                var nickname = new SACCOUNT_NICKNAME
                {
                    OriginalNickName = character.Nickname,
                    StreamingModeNickName = character.StreamingNickname
                };

                record.NickName = nickname;
                res.Records.Add(record);
            }

            return res;
        }
    }
}

