using DarkAndDarker.Cryptography.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GatheringHallService
{
    private static readonly Dictionary<string, Dictionary<string, object>> channels = new Dictionary<string, Dictionary<string, object>>();

    static GatheringHallService()
    {
        for (int i = 1; i <= 6; i++)
        {
            channels[$"channel{i}"] = new Dictionary<string, object>
            {
                ["index"] = i,
                ["clients"] = new List<Context>()
            };
        }
    }

    public static SS2C_GATHERING_HALL_CHANNEL_LIST_RES GatheringHallChannelList(Context ctx, byte[] msg)
    {
        var req = SC2S_GATHERING_HALL_CHANNEL_LIST_REQ.Parser.ParseFrom(msg);
        var res = new SS2C_GATHERING_HALL_CHANNEL_LIST_RES();

        foreach (var ch in channels)
        {
            var channelInfo = new SGATHERING_HALL_CHANNEL
            {
                channelIndex = (int)ch.Value["index"],
                channelId = ch.Value["index"].ToString(),
                memberCount = ((List<Context>)ch.Value["clients"]).Count,
                groupIndex = (int)ch.Value["index"]
            };

            res.channels.Add(channelInfo);
        }

        return res;
    }

    public static SS2C_GATHERING_HALL_CHANNEL_SELECT_RES GatheringHallSelectChannel(Context ctx, byte[] msg)
    {
        var req = SC2S_GATHERING_HALL_CHANNEL_SELECT_REQ.Parser.ParseFrom(msg);
        var channelKey = $"channel{req.channelIndex}";

        if (channels.ContainsKey(channelKey))
        {
            ((List<Context>)channels[channelKey]["clients"]).Add(ctx);
        }

        return new SS2C_GATHERING_HALL_CHANNEL_SELECT_RES { result = PacketCommand.SUCCESS };
    }

    public static SS2C_GATHERING_HALL_TARGET_EQUIPPED_ITEM_RES GatheringHallEquip(Context ctx, byte[] msg)
    {
        var req = SC2S_GATHERING_HALL_TARGET_EQUIPPED_ITEM_REQ.Parser.ParseFrom(msg);
        var query = db.Query<Character>().FirstOrDefault(c => c.id == req.characterId);
        var charinfo = new SCHARACTER_GATHERING_HALL_INFO
        {
            accountId = req.accountId,
            nickName = new SACCOUNT_NICKNAME
            {
                originalNickName = query.nickname,
                streamingModeNickName = query.streaming_nickname
            }
        };

        return new SS2C_GATHERING_HALL_TARGET_EQUIPPED_ITEM_RES
        {
            result = PacketCommand.SUCCESS,
            equippedItems = null,
            characterInfo = charinfo
        };
    }

    public static void Cleanup(Context ctx)
    {
        string currentChannel = null;

        foreach (var ch in channels)
        {
            if (((List<Context>)ch.Value["clients"]).Contains(ctx))
            {
                currentChannel = ch.Key;
                break;
            }
        }

        if (currentChannel != null)
        {
            ((List<Context>)channels[currentChannel]["clients"]).Remove(ctx);
        }
    }

    public static SS2C_GATHERING_HALL_CHANNEL_EXIT_RES GatheringHallChannelExit(Context ctx, byte[] msg)
    {
        var req = SC2S_GATHERING_HALL_CHANNEL_EXIT_REQ.Parser.ParseFrom(msg);
        string currentChannel = null;

        foreach (var ch in channels)
        {
            if (((List<Context>)ch.Value["clients"]).Contains(ctx))
            {
                currentChannel = ch.Key;
                break;
            }
        }

        if (currentChannel != null)
        {
            ((List<Context>)channels[currentChannel]["clients"]).Remove(ctx);
        }

        var res = new SS2C_GATHERING_HALL_CHANNEL_EXIT_RES { result = PacketCommand.SUCCESS };
        ctx.Reply(GatheringHallChannelList(ctx, msg));

        return res;
    }

    public static void BroadcastChat(Context ctx, byte[] msg)
    {
        var res = new SS2C_GATHERING_HALL_CHANNEL_CHAT_RES { result = PacketCommand.SUCCESS, chats = { msg } };
        string currentChannel = null;

        foreach (var ch in channels)
        {
            if (((List<Context>)ch.Value["clients"]).Contains(ctx))
            {
                currentChannel = ch.Key;
                break;
            }
        }

        if (currentChannel != null)
        {
            foreach (var client in (List<Context>)channels[currentChannel]["clients"])
            {
                if (client != ctx)
                {
                    client.Reply(res);
                }
            }
        }
    }

    public static SS2C_GATHERING_HALL_CHANNEL_CHAT_RES Chat(Context ctx, byte[] msg)
    {
        var req = SC2S_GATHERING_HALL_CHANNEL_CHAT_REQ.Parser.ParseFrom(msg);
        var character = sessions[ctx.Transport].character;

        var chatType = req.chat.chatType;
        var chatPiece = req.chat.chatData.chatDataPieceArray.First();
        var chatStr = chatPiece.chatStr;
        var item = chatPiece.chatDataPieceItem;

        var propertyList = item.pp.Select(pp => new SCHATDATA_PIECE_ITEM_PROPERTY
        {
            pid = pp.pid,
            pv = pp.pv
        }).ToList();

        var chatPieceItemObj = new SCHATDATA_PIECE_ITEM
        {
            uid = item.uid,
            iid = item.iid,
            pp = { propertyList }
        };

        var chatData = new SCHATDATA
        {
            accountId = sessions[ctx.Transport].account.id.ToString(),
            characterId = sessions[ctx.Transport].character.id.ToString(),
            nickname = new SACCOUNT_NICKNAME
            {
                originalNickName = character.nickname,
                streamingModeNickName = character.streaming_nickname
            },
            partyId = sessions[ctx.Transport].party.id.ToString()
        };

        var chatPieceObj = new SCHATDATA_PIECE
        {
            chatStr = chatStr,
            chatDataPieceItem = chatPieceItemObj
        };

        chatData.chatDataPieceArray.Add(chatPieceObj);

        var chatHall = new SGATHERING_HALL_CHAT_S2C
        {
            chatIndex = 1,
            chatType = chatType,
            time = 1,
            chatData = chatData
        };

        var logMsg = new ChatLog
        {
            message = chatStr,
            account_id = sessions[ctx.Transport].account.id,
            chat_type = chatType,
            chat_index = 1
        };
        logMsg.Save();

        BroadcastChat(ctx, chatHall.ToByteArray());

        return new SS2C_GATHERING_HALL_CHANNEL_CHAT_RES
        {
            result = PacketCommand.SUCCESS,
            chats = { chatHall }
        };
    }
}
