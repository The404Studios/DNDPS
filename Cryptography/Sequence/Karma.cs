// Karma.cs

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace DC.Packet.Karma
{
    public sealed partial class SKARMA_CHARACTER_INFO : IMessage<SKARMA_CHARACTER_INFO>
    {
        public string AccountId { get; set; }
        public string CharacterId { get; set; }
        public SACCOUNT_NICKNAME NickName { get; set; }
        public string CharacterClass { get; set; }
        public uint Gender { get; set; }
        public uint IsVote { get; set; }
        public uint KarmaAction { get; set; }
        public uint KarmaStatus { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SKARMA_CHARACTER_INFO Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SKARMA_CHARACTER_INFO? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SKARMA_CHARACTER_INFO message)
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

        // Implement IMessage<SKARMA_CHARACTER_INFO>
    }

    public sealed partial class SKARMA_MOST_RECENT_MATCH_INFO : IMessage<SKARMA_MOST_RECENT_MATCH_INFO>
    {
        public uint MatchIdx { get; set; }
        public RepeatedField<SKARMA_CHARACTER_INFO> CharacterInfos { get; } = new RepeatedField<SKARMA_CHARACTER_INFO>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SKARMA_MOST_RECENT_MATCH_INFO Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SKARMA_MOST_RECENT_MATCH_INFO? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SKARMA_MOST_RECENT_MATCH_INFO message)
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

        // Implement IMessage<SKARMA_MOST_RECENT_MATCH_INFO>
    }

    public sealed partial class SC2S_KARMA_REPORT_LIST_REQ : IMessage<SC2S_KARMA_REPORT_LIST_REQ>
    {
        // Implement IMessage<SC2S_KARMA_REPORT_LIST_REQ>
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_KARMA_REPORT_LIST_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_KARMA_REPORT_LIST_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_KARMA_REPORT_LIST_REQ message)
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

    public sealed partial class SS2C_KARMA_REPORT_LIST_RES : IMessage<SS2C_KARMA_REPORT_LIST_RES>
    {
        public RepeatedField<SKARMA_MOST_RECENT_MATCH_INFO> MatchInfos { get; } = new RepeatedField<SKARMA_MOST_RECENT_MATCH_INFO>();
        public uint CurrentTicketCount { get; set; }
        public uint CollectionStepCount { get; set; }
        public uint MaxCollectionCount { get; set; }
        public uint MaxTicketCount { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_KARMA_REPORT_LIST_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_KARMA_REPORT_LIST_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_KARMA_REPORT_LIST_RES message)
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

        // Implement IMessage<SS2C_KARMA_REPORT_LIST_RES>
    }

    public sealed partial class SC2S_KARMA_REPORT_ACTION_REQ : IMessage<SC2S_KARMA_REPORT_ACTION_REQ>
    {
        public uint MatchIdx { get; set; }
        public string AccountId { get; set; }
        public string CharacterId { get; set; }
        public uint Action { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_KARMA_REPORT_ACTION_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_KARMA_REPORT_ACTION_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_KARMA_REPORT_ACTION_REQ message)
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

        // Implement IMessage<SC2S_KARMA_REPORT_ACTION_REQ>
    }

    public sealed partial class SS2C_KARMA_REPORT_ACTION_RES : IMessage<SS2C_KARMA_REPORT_ACTION_RES>
    {
        public uint Result { get; set; }
        public uint MatchIdx { get; set; }
        public SKARMA_CHARACTER_INFO UpdateCharacterInfo { get; set; }
        public uint CurrentTicketCount { get; set; }
        public uint CollectionStepCount { get; set; }
        public uint MaxCollectionCount { get; set; }
        public uint MaxTicketCount { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_KARMA_REPORT_ACTION_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_KARMA_REPORT_ACTION_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_KARMA_REPORT_ACTION_RES message)
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

        // Implement IMessage<SS2C_KARMA_REPORT_ACTION_RES>
    }

    public sealed partial class SS2C_KARMA_RATING_UPDATE_NOT : IMessage<SS2C_KARMA_RATING_UPDATE_NOT>
    {
        public int UpdateKarmaRating { get; set; }
        public string AccountId { get; set; }
        public string CharacterId { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_KARMA_RATING_UPDATE_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_KARMA_RATING_UPDATE_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_KARMA_RATING_UPDATE_NOT message)
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

        // Implement IMessage<SS2C_KARMA_RATING_UPDATE_NOT>
    }
}
