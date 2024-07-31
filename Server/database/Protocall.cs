using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

public class GameServer
{
    private TcpListener _listener;
    private ConcurrentDictionary<TcpClient, User> _sessions = new ConcurrentDictionary<TcpClient, User>();

    public async Task StartAsync(IPAddress ipAddress, int port)
    {
        _listener = new TcpListener(ipAddress, port);
        _listener.Start();
        Console.WriteLine($"Server started on {ipAddress}:{port}");

        while (true)
        {
            var client = await _listener.AcceptTcpClientAsync();
            Console.WriteLine($"Received connection from: {((IPEndPoint)client.Client.RemoteEndPoint).Address}:{((IPEndPoint)client.Client.RemoteEndPoint).Port}");
            _sessions[client] = new User();
            _ = ProcessClientAsync(client);
        }
    }

    private async Task ProcessClientAsync(TcpClient client)
    {
        try
        {
            var stream = client.GetStream();
            var buffer = new byte[8192];
            while (client.Connected)
            {
                var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;

                // Process incoming data
                await ProcessDataAsync(client, buffer, bytesRead);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Lost connection to: {((IPEndPoint)client.Client.RemoteEndPoint).Address}:{((IPEndPoint)client.Client.RemoteEndPoint).Port}");
            _sessions.TryRemove(client, out _);
            // Cleanup resources related to the client
        }
    }

    private async Task ProcessDataAsync(TcpClient client, byte[] data, int length)
    {
        // Assuming data is in a specific format with a header of length 8
        var packetLength = BitConverter.ToUInt16(data, 0);
        var packetId = BitConverter.ToUInt16(data, 2);

        // Handle packets based on packetId
        if (packetLength <= length)
        {
            var packetData = new byte[packetLength];
            Array.Copy(data, 8, packetData, 0, packetLength - 8);

            // Dispatch to handlers
            await HandlePacketAsync(client, packetId, packetData);
        }
    }

    private async Task HandlePacketAsync(TcpClient client, ushort packetId, byte[] packetData)
    {
        // Replace with actual packet handlers
        switch (packetId)
        {
            case (ushort)PacketCommand.C2S_ALIVE_REQ:
                await SendHeartbeatAsync(client);
                break;
            // Add cases for other packet IDs
            default:
                Console.WriteLine($"Received unknown packet ID: {packetId}");
                break;
        }
    }

    private async Task SendHeartbeatAsync(TcpClient client)
    {
        var heartbeatResponse = new byte[] { /* Construct your response */ };
        var stream = client.GetStream();
        await stream.WriteAsync(heartbeatResponse, 0, heartbeatResponse.Length);
    }

    public class User
    {
        // User properties and methods
    }

    public enum PacketCommand
    {
        C2S_ALIVE_REQ = 0x01
        // Define other packet commands
    }
}

public class Protocall
{
    public static async Task Main(string[] args)
    {
        var server = new GameServer();
        await server.StartAsync(IPAddress.Any, 12345);
    }
}
