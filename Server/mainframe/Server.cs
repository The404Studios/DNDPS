using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

class Server
{
    private static readonly string DbFilePath = "dndserver.db";
    private static readonly string Host = "localhost"; // Replace with your config.host
    private static readonly int Port = 12345; // Replace with your config.port

    static async Task Main(string[] args)
    {
        // Set up a cancellation token for graceful shutdown
        var cts = new CancellationTokenSource();
        Console.CancelKeyPress += (sender, e) =>
        {
            e.Cancel = true;
            cts.Cancel();
        };

        // Stop the server from executing if the database is missing.
        if (!File.Exists(DbFilePath))
        {
            Console.Error.WriteLine("dndserver.db doesn't exist, did you run alembic upgrade head?");
            return;
        }

        // Start the console function in a separate thread
        var consoleThread = new Thread(new ThreadStart(ConsoleFunc));
        consoleThread.Start();

        // Start running the TCP server.
        Console.WriteLine($"Running game server on tcp://{Host}:{Port}");
        await RunServer(cts.Token);
    }

    private static void ConsoleFunc()
    {
        // Implement your console function logic here
        Console.WriteLine("Console thread started. Type 'exit' to stop the server.");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                Environment.Exit(0);
            }
        }
    }

    private static async Task RunServer(CancellationToken token)
    {
        var listener = new TcpListener(IPAddress.Parse(Host), Port);
        listener.Start();

        while (!token.IsCancellationRequested)
        {
            if (listener.Pending())
            {
                var client = await listener.AcceptTcpClientAsync();
                Console.WriteLine("Client connected");
                // Handle client connection here
            }

            await Task.Delay(100); // Slight delay to prevent tight loop
        }

        listener.Stop();
    }
}
