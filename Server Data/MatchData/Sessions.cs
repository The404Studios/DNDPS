using System.Collections.Generic;
using System.Net.Sockets;

public static class Sessions
{
    public static Dictionary<TcpClient, User> Items { get; } = new Dictionary<TcpClient, User>();
}
