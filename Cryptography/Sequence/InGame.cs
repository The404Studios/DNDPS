using DC.Packet;
using Google.Protobuf;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;

namespace DC.Packet
{
    public sealed partial class SS2C_ENTER_GAME_SERVER_NOT : IMessage<SS2C_ENTER_GAME_SERVER_NOT>
    {
        // Implement message serialization and deserialization
        // Other members...
    }

    public sealed partial class SC2S_AUTO_MATCH_REG_REQ : IMessage<SC2S_AUTO_MATCH_REG_REQ>
    {
        // Implement message serialization and deserialization
        // Other members...
    }

    public enum MODE
    {
        NONE = 0,
        REGISTER = 1,
        CANCEL = 2
    }

    public sealed partial class SS2C_AUTO_MATCH_REG_RES : IMessage<SS2C_AUTO_MATCH_REG_RES>
    {
        // Implement message serialization and deserialization
        // Other members...
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_AUTO_MATCH_REG_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_AUTO_MATCH_REG_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_AUTO_MATCH_REG_RES message)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(CodedInputStream input)
        {
            throw new NotImplementedException();
        }

        public void WriteTo(CodedOutputStream output)
        {
            throw new NotImplementedException();
        }
    }

    public enum RESULT
    {
        NONE = 0,
        SUCCESS = 1,
        FAIL = 2,
        FAIL_ALREADY_TRYING = 3,
        FAIL_NO_READY_PARTY_MEMBER = 4,
        FAIL_REGION_SELECT = 5,
        FAIL_SERVER_DISABLE = 6,
        FAIL_SHORTAGE_ENTRANCE_FEE = 7,
        FAIL_SOLO_ONLY = 8,
        FAIL_SHORTAGE_LEVEL = 9
    }

    public sealed partial class SC2S_GAME_ENTER_COMPLETE_NOT : IMessage<SC2S_GAME_ENTER_COMPLETE_NOT>
    {
        // Implement message serialization and deserialization
        // Other members...
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_GAME_ENTER_COMPLETE_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_GAME_ENTER_COMPLETE_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_GAME_ENTER_COMPLETE_NOT message)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(CodedInputStream input)
        {
            throw new NotImplementedException();
        }

        public void WriteTo(CodedOutputStream output)
        {
            throw new NotImplementedException();
        }
    }

    public sealed partial class SS2C_AUTO_MATCH_REG_TEAM_NOT : IMessage<SS2C_AUTO_MATCH_REG_TEAM_NOT>
    {
        // Implement message serialization and deserialization
        // Other members...
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_AUTO_MATCH_REG_TEAM_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_AUTO_MATCH_REG_TEAM_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_AUTO_MATCH_REG_TEAM_NOT message)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(CodedInputStream input)
        {
            throw new NotImplementedException();
        }

        public void WriteTo(CodedOutputStream output)
        {
            throw new NotImplementedException();
        }
    }

    public sealed partial class SC2S_RECONNECT_INGAME_REQ : IMessage<SC2S_RECONNECT_INGAME_REQ>
    {
        // Implement message serialization and deserialization
        // Other members...
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_RECONNECT_INGAME_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_RECONNECT_INGAME_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_RECONNECT_INGAME_REQ message)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(CodedInputStream input)
        {
            throw new NotImplementedException();
        }

        public void WriteTo(CodedOutputStream output)
        {
            throw new NotImplementedException();
        }
    }

    public sealed partial class SS2C_RECONNECT_INGAME_RES : IMessage<SS2C_RECONNECT_INGAME_RES>
    {
        // Implement message serialization and deserialization
        // Other members...
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_RECONNECT_INGAME_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_RECONNECT_INGAME_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_RECONNECT_INGAME_RES message)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(CodedInputStream input)
        {
            throw new NotImplementedException();
        }

        public void WriteTo(CodedOutputStream output)
        {
            throw new NotImplementedException();
        }
    }

    public sealed partial class SS2C_FLOOR_MATCHMAKED_NOT : IMessage<SS2C_FLOOR_MATCHMAKED_NOT>
    {
        // Implement message serialization and deserialization
        // Other members...
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_FLOOR_MATCHMAKED_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_FLOOR_MATCHMAKED_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_FLOOR_MATCHMAKED_NOT message)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(CodedInputStream input)
        {
            throw new NotImplementedException();
        }

        public void WriteTo(CodedOutputStream output)
        {
            throw new NotImplementedException();
        }
    }
}


class InGame
{
    static void Main()
    {
        // Create an instance of SC2S_GM_PARTY_ALL_RANDOM_REQ
        var request = new SC2S_GM_PARTY_ALL_RANDOM_REQ();

        // Create an instance of SC2S_AUTO_MATCH_REG_REQ
        var request2 = new SC2S_AUTO_MATCH_REG_REQ
        {
            Mode = SC2S_AUTO_MATCH_REG_REQ.Types.MODE.Register,
            Region = 1,
            DifficultyType = 2
        };

        // Serialize to a byte array
        byte[] serializedRequest = request.ToByteArray();

        // Deserialize from a byte array
        var deserializedRequest = SC2S_AUTO_MATCH_REG_REQ.Parser.ParseFrom(serializedRequest);

        // Similarly for other messages

        // Serialize to a byte array
        byte[] serializedRequest2 = request.ToByteArray();

        // Deserialize from a byte array
        var deserializedRequest1 = SC2S_GM_PARTY_ALL_RANDOM_REQ.Parser.ParseFrom(serializedRequest);

        // Similarly for SS2C_GM_PARTY_ALL_RANDOM_RES
        var response = new SS2C_GM_PARTY_ALL_RANDOM_RES();
        byte[] serializedResponse = response.ToByteArray();
        var deserializedResponse = SS2C_GM_PARTY_ALL_RANDOM_RES.Parser.ParseFrom(serializedResponse);
    }
}




