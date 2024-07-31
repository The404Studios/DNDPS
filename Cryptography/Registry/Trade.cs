using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using System;
using System.IO;
using YourNamespace; // Replace with the actual namespace of the generated classes

class Trade
{
    static void Main()
    {
        // Create an instance of a message
        var tradeChannel = new STRADE_CHANNEL
        {
            Index = 1,
            ChannelName = "Trade Channel 1",
            MemberCount = 10,
            RoomType = 2,
            GroupIndex = 3
        };

        // Serialize the message to a byte array
        byte[] serializedData;
        using (var stream = new MemoryStream())
        {
            tradeChannel.WriteTo(stream);
            serializedData = stream.ToArray();
        }

        // Deserialize the message from a byte array
        STRADE_CHANNEL deserializedTradeChannel;
        using (var stream = new MemoryStream(serializedData))
        {
            deserializedTradeChannel = STRADE_CHANNEL.Parser.ParseFrom(stream);
        }

        // Use the deserialized message
        Console.WriteLine($"Index: {deserializedTradeChannel.Index}");
        Console.WriteLine($"ChannelName: {deserializedTradeChannel.ChannelName}");
        Console.WriteLine($"MemberCount: {deserializedTradeChannel.MemberCount}");
        Console.WriteLine($"RoomType: {deserializedTradeChannel.RoomType}");
        Console.WriteLine($"GroupIndex: {deserializedTradeChannel.GroupIndex}");
    }
}

