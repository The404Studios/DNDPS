using System;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

public static class Utils
{
    public static byte[] MakeHeader(byte[] msg)
    {
        // header: <packet length: short> 00 00 <packet id: short> 00 00
        short packetLength = (short)(msg.Length + 8);
        short packetId = (short)PacketCommand.S2C; // Example, replace with actual logic

        byte[] header = new byte[8];
        BitConverter.GetBytes(packetLength).CopyTo(header, 0);
        BitConverter.GetBytes(packetId).CopyTo(header, 4);
        return header;
    }

    public static (TcpClient, User) GetUser(string username = null, string nickname = null, int? accountId = null)
    {
        if (username == null && nickname == null && accountId == null)
        {
            throw new Exception("Did not pass username, nickname, or account_id, need at least one");
        }

        foreach (var kvp in Sessions.Items)
        {
            var session = kvp.Value;
            if ((username == null || (session.Account?.Username) != username) &&
                (nickname == null || (session.Character?.Nickname) != nickname) &&
                (accountId == null || (session.Account?.Id) != accountId))
            {
                continue;
            }
            return (kvp.Key, session);
        }

        return (null, null);
    }

    public static User GetParty(string username = null, string nickname = null, int? accountId = null)
    {
        if (username == null && nickname == null && accountId == null)
        {
            throw new Exception("Did not pass username, nickname, or account_id, need at least one");
        }

        foreach (var kvp in Sessions.Items)
        {
            var session = kvp.Value;
            if ((username != null && session.Account?.Username == username) ||
                (nickname != null && session.Character?.Nickname == nickname) ||
                (accountId != null && session.Account?.Id == accountId))
            {
                return session.Party;
            }
        }

        return null;
    }
}
