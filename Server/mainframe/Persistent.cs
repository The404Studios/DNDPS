using System.Collections.Concurrent;
using System.Net.Sockets;

public static class Persistent
{
    // ConcurrentDictionary to store session data safely in a multi-threaded environment
    public static ConcurrentDictionary<TcpClient, User> Sessions { get; } = new ConcurrentDictionary<TcpClient, User>();
}
