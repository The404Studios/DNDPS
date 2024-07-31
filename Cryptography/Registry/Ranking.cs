using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace DC.Packet
{
    public sealed partial class SRankRecord : IMessage<SRankRecord>
    {
        public const int PageIndexFieldNumber = 1;
        public const int RankFieldNumber = 2;
        public const int ScoreFieldNumber = 3;
        public const int PercentageFieldNumber = 4;
        public const int AccountIdFieldNumber = 5;
        public const int NickNameFieldNumber = 6;
        public const int CharacterClassFieldNumber = 7;

        private uint pageIndex_;
        private uint rank_;
        private uint score_;
        private float percentage_;
        private string accountId_ = "";
        private SCACCOUNT_NICKNAME nickName_;
        private string characterClass_ = "";

        public uint PageIndex
        {
            get => pageIndex_;
            set => pageIndex_ = value;
        }

        public uint Rank
        {
            get => rank_;
            set => rank_ = value;
        }

        public uint Score
        {
            get => score_;
            set => score_ = value;
        }

        public float Percentage
        {
            get => percentage_;
            set => percentage_ = value;
        }

        public string AccountId
        {
            get => accountId_;
            set => accountId_ = value;
        }

        public SCACCOUNT_NICKNAME NickName
        {
            get => nickName_;
            set => nickName_ = value;
        }

        public string CharacterClass
        {
            get => characterClass_;
            set => characterClass_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SRankRecord Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SRankRecord? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SRankRecord message)
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

        // Implement IMessage methods here...
    }

    public sealed partial class SC2S_RANKING_RANGE_REQ : IMessage<SC2S_RANKING_RANGE_REQ>
    {
        public const int RankTypeFieldNumber = 1;
        public const int StartIndexFieldNumber = 2;
        public const int EndIndexFieldNumber = 3;
        public const int CharacterClassFieldNumber = 4;

        private uint rankType_;
        private uint startIndex_;
        private uint endIndex_;
        private string characterClass_ = "";

        public uint RankType
        {
            get => rankType_;
            set => rankType_ = value;
        }

        public uint StartIndex
        {
            get => startIndex_;
            set => startIndex_ = value;
        }

        public uint EndIndex
        {
            get => endIndex_;
            set => endIndex_ = value;
        }

        public string CharacterClass
        {
            get => characterClass_;
            set => characterClass_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_RANKING_RANGE_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_RANKING_RANGE_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_RANKING_RANGE_REQ message)
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

        // Implement IMessage methods here...
    }

    public sealed partial class SS2C_RANKING_RANGE_RES : IMessage<SS2C_RANKING_RANGE_RES>
    {
        public const int ResultFieldNumber = 1;
        public const int RecordsFieldNumber = 2;
        public const int RankTypeFieldNumber = 3;
        public const int AllRowCountFieldNumber = 4;
        public const int StartIndexFieldNumber = 5;
        public const int EndIndexFieldNumber = 6;
        public const int CharacterClassFieldNumber = 7;

        private uint result_;
        private readonly RepeatedField<SRankRecord> records_ = new RepeatedField<SRankRecord>();
        private uint rankType_;
        private uint allRowCount_;
        private uint startIndex_;
        private uint endIndex_;
        private string characterClass_ = "";

        public uint Result
        {
            get => result_;
            set => result_ = value;
        }

        public RepeatedField<SRankRecord> Records => records_;

        public uint RankType
        {
            get => rankType_;
            set => rankType_ = value;
        }

        public uint AllRowCount
        {
            get => allRowCount_;
            set => allRowCount_ = value;
        }

        public uint StartIndex
        {
            get => startIndex_;
            set => startIndex_ = value;
        }

        public uint EndIndex
        {
            get => endIndex_;
            set => endIndex_ = value;
        }

        public string CharacterClass
        {
            get => characterClass_;
            set => characterClass_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SS2C_RANKING_RANGE_RES message)
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

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_RANKING_RANGE_RES? other)
        {
            throw new NotImplementedException();
        }

        public SS2C_RANKING_RANGE_RES Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here...
    }

    public sealed partial class SC2S_RANKING_NEARBY_REQ : IMessage<SC2S_RANKING_NEARBY_REQ>
    {
        public const int RankTypeFieldNumber = 1;
        public const int SearchRangeFieldNumber = 2;
        public const int SearchIndexFieldNumber = 3;
        public const int CharacterClassFieldNumber = 4;

        private uint rankType_;
        private uint searchRange_;
        private uint searchIndex_;
        private string characterClass_ = "";

        public uint RankType
        {
            get => rankType_;
            set => rankType_ = value;
        }

        public uint SearchRange
        {
            get => searchRange_;
            set => searchRange_ = value;
        }

        public uint SearchIndex
        {
            get => searchIndex_;
            set => searchIndex_ = value;
        }

        public string CharacterClass
        {
            get => characterClass_;
            set => characterClass_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_RANKING_NEARBY_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_RANKING_NEARBY_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_RANKING_NEARBY_REQ message)
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

        // Implement IMessage methods here...
    }

    public sealed partial class SS2C_RANKING_NEARBY_RES : IMessage<SS2C_RANKING_NEARBY_RES>
    {
        public const int ResultFieldNumber = 1;
        public const int RecordsFieldNumber = 2;
        public const int RankTypeFieldNumber = 3;
        public const int AllRowCountFieldNumber = 4;
        public const int SearchRangeFieldNumber = 5;
        public const int CharacterClassFieldNumber = 6;

        private uint result_;
        private readonly RepeatedField<SRankRecord> records_ = new RepeatedField<SRankRecord>();
        private uint rankType_;
        private uint allRowCount_;
        private uint searchRange_;
        private string characterClass_ = "";

        public uint Result
        {
            get => result_;
            set => result_ = value;
        }

        public RepeatedField<SRankRecord> Records => records_;

        public uint RankType
        {
            get => rankType_;
            set => rankType_ = value;
        }

        public uint AllRowCount
        {
            get => allRowCount_;
            set => allRowCount_ = value;
        }

        public uint SearchRange
        {
            get => searchRange_;
            set => searchRange_ = value;
        }

        public string CharacterClass
        {
            get => characterClass_;
            set => characterClass_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SS2C_RANKING_NEARBY_RES message)
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

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_RANKING_NEARBY_RES? other)
        {
            throw new NotImplementedException();
        }

        public SS2C_RANKING_NEARBY_RES Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here...
    }

    public sealed partial class SC2S_RANKING_CHARACTER_REQ : IMessage<SC2S_RANKING_CHARACTER_REQ>
    {
        public const int RankTypeFieldNumber = 1;
        public const int NickNameFieldNumber = 2;
        public const int CharacterClassFieldNumber = 3;

        private uint rankType_;
        private SCACCOUNT_NICKNAME nickName_;
        private string characterClass_ = "";

        public uint RankType
        {
            get => rankType_;
            set => rankType_ = value;
        }

        public SCACCOUNT_NICKNAME NickName
        {
            get => nickName_;
            set => nickName_ = value;
        }

        public string CharacterClass
        {
            get => characterClass_;
            set => characterClass_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_RANKING_CHARACTER_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_RANKING_CHARACTER_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_RANKING_CHARACTER_REQ message)
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

        // Implement IMessage methods here...
    }

    public sealed partial class SS2C_RANKING_CHARACTER_RES : IMessage<SS2C_RANKING_CHARACTER_RES>
    {
        public const int ResultFieldNumber = 1;
        public const int RankRecordFieldNumber = 2;
        public const int RankTypeFieldNumber = 3;
        public const int AllRowCountFieldNumber = 4;
        public const int CharacterClassFieldNumber = 5;

        private uint result_;
        private SRankRecord rankRecord_;
        private uint rankType_;
        private uint allRowCount_;
        private string characterClass_ = "";

        public uint Result
        {
            get => result_;
            set => result_ = value;
        }

        public SRankRecord RankRecord
        {
            get => rankRecord_;
            set => rankRecord_ = value;
        }

        public uint RankType
        {
            get => rankType_;
            set => rankType_ = value;
        }

        public uint AllRowCount
        {
            get => allRowCount_;
            set => allRowCount_ = value;
        }

        public string CharacterClass
        {
            get => characterClass_;
            set => characterClass_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_RANKING_CHARACTER_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_RANKING_CHARACTER_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_RANKING_CHARACTER_RES message)
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

        // Implement IMessage methods here...
    }

    public enum RANKING_TYPE
    {
        NONE = 0,
        COIN = 1,
        KILL = 2,
        ESCAPE = 3,
        ADVENTURE = 4,
        BOSSKILL_LICH = 5,
        BOSSKILL_GHOSTKING = 6
    }
}
