using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var commandHandler = new CommandHandler();
        commandHandler.StartConsole();
    }
}


public class CommandHandler
{
    private readonly Dictionary<string, Command> commands;

    public CommandHandler()
    {
        commands = new Dictionary<string, Command>
        {
            { "/help", new Command(Help, "/help - Show help") },
            { "/give", new Command(GiveItem, "/give <user> <item_name> <item_type> [rarity] [amount] - Give someone an item") },
            { "/enum", new Command(EnumItems, "/enum items|rarity [filter] - List enums") },
            { "/exit", new Command(Exit, "/exit - Gracefully exit the server") },
            { "/list", new Command(List, "/list [dungeon|lobby] - List players online") }
            // Add more commands here
        };
    }

    public void StartConsole()
    {
        string line;
        while (true)
        {
            Console.Write("> ");
            line = Console.ReadLine();

            if (string.IsNullOrEmpty(line))
                continue;

            var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (commands.TryGetValue(parts[0], out var command))
            {
                try
                {
                    command.Action(parts.Skip(1).ToArray());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing command: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Type /help to get the list of commands");
            }
        }
    }

    private void Help(string[] args)
    {
        Console.WriteLine("List of available commands:");
        foreach (var command in commands.Values)
        {
            Console.WriteLine(command.HelpText);
        }
    }

    private void GiveItem(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Usage: /give <user> <item_name> <item_type> [rarity] [amount]");
            return;
        }

        var user = args[0];
        var itemName = args[1];
        var itemType = args[2];
        var rarity = args.Length > 3 ? args[3] : "NONE";
        var amount = args.Length > 4 ? int.Parse(args[4]) : 1;

        // Implement logic to give item here
        Console.WriteLine($"Giving item '{itemName}' of type '{itemType}' and rarity '{rarity}' to user '{user}' with amount {amount}.");
    }

    private void EnumItems(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: /enum items|rarity [filter]");
            return;
        }

        var type = args[0];
        var filter = args.Length > 1 ? args[1] : null;

        // Implement enumeration logic here
        Console.WriteLine($"Enumerating {type} with filter '{filter}'.");
    }

    private void List(string[] args)
    {
        var location = args.Length > 0 ? args[0] : null;

        // Implement listing logic here
        Console.WriteLine($"Listing players in location: {location ?? "all"}");
    }

    private void Exit(string[] args)
    {
        Environment.Exit(0);
    }
}

public class Command
{
    public Action<string[]> Action { get; }
    public string HelpText { get; }

    public Command(Action<string[]> action, string helpText)
    {
        Action = action;
        HelpText = helpText;
    }
}


class ConfigLoader
{
    static void Main(string[] args)
    {
        var configLoader = new ConfigLoader();
        var config = configLoader.LoadConfig("config.yml");

        Console.WriteLine($"Starting Level: {config.GameSettings.StartingLevel}");
    }
}
