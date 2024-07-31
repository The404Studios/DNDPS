// Generated code by the Protocol Buffers compiler. DO NOT EDIT!

using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace DarkAndDarker.Cryptography.Sequence.CharacterClass
{
    public sealed partial class SCLASS_EQUIP_INFO : IMessage<SCLASS_EQUIP_INFO>
    {
        public const int IndexFieldNumber = 1;
        private int index_;
        public int Index
        {
            get { return index_; }
            set { index_ = value; }
        }

        public const int IsAvailableSlotFieldNumber = 2;
        private int isAvailableSlot_;
        public int IsAvailableSlot
        {
            get { return isAvailableSlot_; }
            set { isAvailableSlot_ = value; }
        }

        public const int RequiredLevelFieldNumber = 3;
        private int requiredLevel_;
        public int RequiredLevel
        {
            get { return requiredLevel_; }
            set { requiredLevel_ = value; }
        }

        public const int TypeFieldNumber = 4;
        private int type_;
        public int Type
        {
            get { return type_; }
            set { type_ = value; }
        }

        public const int EquipIdFieldNumber = 5;
        private string equipId_ = "";
        public string EquipId
        {
            get { return equipId_; }
            set { equipId_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SCLASS_EQUIP_INFO message)
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

        public bool Equals(SCLASS_EQUIP_INFO? other)
        {
            throw new NotImplementedException();
        }

        public SCLASS_EQUIP_INFO Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SCLASS_MOVE_INFO : IMessage<SCLASS_MOVE_INFO>
    {
        public const int IndexFieldNumber = 1;
        private int index_;
        public int Index
        {
            get { return index_; }
            set { index_ = value; }
        }

        public const int TypeFieldNumber = 2;
        private int type_;
        public int Type
        {
            get { return type_; }
            set { type_ = value; }
        }

        public const int MoveIdFieldNumber = 3;
        private string moveId_ = "";
        public string MoveId
        {
            get { return moveId_; }
            set { moveId_ = value; }
        }

        public const int MoveFieldNumber = 4;
        private int move_;
        public int Move
        {
            get { return move_; }
            set { move_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SCLASS_MOVE_INFO message)
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

        public bool Equals(SCLASS_MOVE_INFO? other)
        {
            throw new NotImplementedException();
        }

        public SCLASS_MOVE_INFO Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SC2S_CLASS_LEVEL_INFO_REQ : IMessage<SC2S_CLASS_LEVEL_INFO_REQ>
    {
        // No fields for this request message
        // Implement IMessage methods here
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CLASS_LEVEL_INFO_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CLASS_LEVEL_INFO_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CLASS_LEVEL_INFO_REQ message)
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

    public sealed partial class SS2C_CLASS_LEVEL_INFO_RES : IMessage<SS2C_CLASS_LEVEL_INFO_RES>
    {
        public const int LevelFieldNumber = 1;
        private int level_;
        public int Level
        {
            get { return level_; }
            set { level_ = value; }
        }

        public const int ExpFieldNumber = 2;
        private int exp_;
        public int Exp
        {
            get { return exp_; }
            set { exp_ = value; }
        }

        public const int ExpBeginFieldNumber = 3;
        private int expBegin_;
        public int ExpBegin
        {
            get { return expBegin_; }
            set { expBegin_ = value; }
        }

        public const int ExpLimitFieldNumber = 4;
        private int expLimit_;
        public int ExpLimit
        {
            get { return expLimit_; }
            set { expLimit_ = value; }
        }

        public const int RewardPointFieldNumber = 5;
        private int rewardPoint_;
        public int RewardPoint
        {
            get { return rewardPoint_; }
            set { rewardPoint_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SS2C_CLASS_LEVEL_INFO_RES message)
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

        public bool Equals(SS2C_CLASS_LEVEL_INFO_RES? other)
        {
            throw new NotImplementedException();
        }

        public SS2C_CLASS_LEVEL_INFO_RES Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    // Define other classes and enums following the pattern above

    public sealed partial class SPerk : IMessage<SPerk>
    {
        // Define fields for SPerk
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SPerk Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SPerk? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SPerk message)
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

    public sealed partial class SSkill : IMessage<SSkill>
    {
        // Define fields for SSkill
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SSkill Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SSkill? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SSkill message)
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

    public sealed partial class SSpell : IMessage<SSpell>
    {
        // Define fields for SSpell
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SSpell Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SSpell? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SSpell message)
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
