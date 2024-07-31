// Lobby.cs

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace DC.Packet
{
    public sealed partial class SC2S_CHARACTER_SELECT_ENTER_REQ : IMessage<SC2S_CHARACTER_SELECT_ENTER_REQ>
    {
        // Implement IMessage<SC2S_CHARACTER_SELECT_ENTER_REQ>
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CHARACTER_SELECT_ENTER_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CHARACTER_SELECT_ENTER_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CHARACTER_SELECT_ENTER_REQ message)
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

    public sealed partial class SS2C_CHARACTER_SELECT_ENTER_RES : IMessage<SS2C_CHARACTER_SELECT_ENTER_RES>
    {
        public uint Result { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CHARACTER_SELECT_ENTER_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CHARACTER_SELECT_ENTER_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CHARACTER_SELECT_ENTER_RES message)
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

        // Implement IMessage<SS2C_CHARACTER_SELECT_ENTER_RES>
    }

    public sealed partial class SC2S_LOBBY_CHARACTER_INFO_REQ : IMessage<SC2S_LOBBY_CHARACTER_INFO_REQ>
    {
        // Implement IMessage<SC2S_LOBBY_CHARACTER_INFO_REQ>
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_LOBBY_CHARACTER_INFO_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_LOBBY_CHARACTER_INFO_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_LOBBY_CHARACTER_INFO_REQ message)
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

    public sealed partial class SS2C_LOBBY_CHARACTER_INFO_RES : IMessage<SS2C_LOBBY_CHARACTER_INFO_RES>
    {
        public uint Result { get; set; }
        public SCHARACTER_INFO CharacterDataBase { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_LOBBY_CHARACTER_INFO_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_LOBBY_CHARACTER_INFO_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_LOBBY_CHARACTER_INFO_RES message)
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

        // Implement IMessage<SS2C_LOBBY_CHARACTER_INFO_RES>
    }

    public sealed partial class SC2S_OPEN_LOBBY_MAP_REQ : IMessage<SC2S_OPEN_LOBBY_MAP_REQ>
    {
        // Implement IMessage<SC2S_OPEN_LOBBY_MAP_REQ>
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_OPEN_LOBBY_MAP_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_OPEN_LOBBY_MAP_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_OPEN_LOBBY_MAP_REQ message)
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

    public sealed partial class SS2C_OPEN_LOBBY_MAP_RES : IMessage<SS2C_OPEN_LOBBY_MAP_RES>
    {
        // Implement IMessage<SS2C_OPEN_LOBBY_MAP_RES>
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_OPEN_LOBBY_MAP_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_OPEN_LOBBY_MAP_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_OPEN_LOBBY_MAP_RES message)
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

    public sealed partial class SC2S_LOBBY_REGION_SELECT_REQ : IMessage<SC2S_LOBBY_REGION_SELECT_REQ>
    {
        public uint Region { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_LOBBY_REGION_SELECT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_LOBBY_REGION_SELECT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_LOBBY_REGION_SELECT_REQ message)
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

        // Implement IMessage<SC2S_LOBBY_REGION_SELECT_REQ>
    }

    public sealed partial class SS2C_LOBBY_REGION_SELECT_RES : IMessage<SS2C_LOBBY_REGION_SELECT_RES>
    {
        public uint Result { get; set; }
        public uint Region { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_LOBBY_REGION_SELECT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_LOBBY_REGION_SELECT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_LOBBY_REGION_SELECT_RES message)
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

        // Implement IMessage<SS2C_LOBBY_REGION_SELECT_RES>
    }

    public sealed partial class SC2S_LOBBY_ENTER_FROM_GAME_REQ : IMessage<SC2S_LOBBY_ENTER_FROM_GAME_REQ>
    {
        // Implement IMessage<SC2S_LOBBY_ENTER_FROM_GAME_REQ>
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_LOBBY_ENTER_FROM_GAME_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_LOBBY_ENTER_FROM_GAME_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_LOBBY_ENTER_FROM_GAME_REQ message)
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

    public sealed partial class SS2C_LOBBY_ENTER_FROM_GAME_RES : IMessage<SS2C_LOBBY_ENTER_FROM_GAME_RES>
    {
        public uint Result { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_LOBBY_ENTER_FROM_GAME_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_LOBBY_ENTER_FROM_GAME_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_LOBBY_ENTER_FROM_GAME_RES message)
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

        // Implement IMessage<SS2C_LOBBY_ENTER_FROM_GAME_RES>
    }

    public sealed partial class SC2S_LOBBY_GAME_DIFFICULTY_SELECT_REQ : IMessage<SC2S_LOBBY_GAME_DIFFICULTY_SELECT_REQ>
    {
        public uint GameDifficultyTypeIndex { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_LOBBY_GAME_DIFFICULTY_SELECT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_LOBBY_GAME_DIFFICULTY_SELECT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_LOBBY_GAME_DIFFICULTY_SELECT_REQ message)
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

        // Implement IMessage<SC2S_LOBBY_GAME_DIFFICULTY_SELECT_REQ>
    }

    public sealed partial class SS2C_LOBBY_GAME_DIFFICULTY_SELECT_RES : IMessage<SS2C_LOBBY_GAME_DIFFICULTY_SELECT_RES>
    {
        public uint Result { get; set; }
        public uint GameDifficultyTypeIndex { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_LOBBY_GAME_DIFFICULTY_SELECT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_LOBBY_GAME_DIFFICULTY_SELECT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_LOBBY_GAME_DIFFICULTY_SELECT_RES message)
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

        // Implement IMessage<SS2C_LOBBY_GAME_DIFFICULTY_SELECT_RES>
    }

    public sealed partial class SACCOUNT_CURRENCY_INFO : IMessage<SACCOUNT_CURRENCY_INFO>
    {
        public uint CurrencyType { get; set; }
        public uint CurrencyValue { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SACCOUNT_CURRENCY_INFO Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SACCOUNT_CURRENCY_INFO? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SACCOUNT_CURRENCY_INFO message)
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

        // Implement IMessage<SACCOUNT_CURRENCY_INFO>
    }

    public sealed partial class SS2C_LOBBY_ACCOUNT_CURRENCY_LIST_NOT : IMessage<SS2C_LOBBY_ACCOUNT_CURRENCY_LIST_NOT>
    {
        public RepeatedField<SACCOUNT_CURRENCY_INFO> CurrencyInfos { get; } = new RepeatedField<SACCOUNT_CURRENCY_INFO>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_LOBBY_ACCOUNT_CURRENCY_LIST_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_LOBBY_ACCOUNT_CURRENCY_LIST_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_LOBBY_ACCOUNT_CURRENCY_LIST_NOT message)
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

        // Implement IMessage<SS2C_LOBBY_ACCOUNT_CURRENCY_LIST_NOT>
    }

    public sealed partial class SS2C_LOBBY_CHARACTER_LOBBY_EMOTE_NOT : IMessage<SS2C_LOBBY_CHARACTER_LOBBY_EMOTE_NOT>
    {
        public RepeatedField<SCUSTOMIZE_LOBBY_EMOTE> LobbyEmoteList { get; } = new RepeatedField<SCUSTOMIZE_LOBBY_EMOTE>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_LOBBY_CHARACTER_LOBBY_EMOTE_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_LOBBY_CHARACTER_LOBBY_EMOTE_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_LOBBY_CHARACTER_LOBBY_EMOTE_NOT message)
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

        // Implement IMessage<SS2C_LOBBY_CHARACTER_LOBBY_EMOTE_NOT>
    }

    public sealed partial class SREPORT_PUNISH_INFO : IMessage<SREPORT_PUNISH_INFO>
    {
        public SACCOUNT_NICKNAME Nickname { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SREPORT_PUNISH_INFO Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SREPORT_PUNISH_INFO? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SREPORT_PUNISH_INFO message)
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

        // Implement IMessage<SREPORT_PUNISH_INFO>
    }

    public sealed partial class SS2C_LOBBY_REPORT_PUNISH_LIST_NOT : IMessage<SS2C_LOBBY_REPORT_PUNISH_LIST_NOT>
    {
        public RepeatedField<SREPORT_PUNISH_INFO> Infos { get; } = new RepeatedField<SREPORT_PUNISH_INFO>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_LOBBY_REPORT_PUNISH_LIST_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_LOBBY_REPORT_PUNISH_LIST_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_LOBBY_REPORT_PUNISH_LIST_NOT message)
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

        // Implement IMessage<SS2C_LOBBY_REPORT_PUNISH_LIST_NOT>
    }

    public sealed partial class SC2S_LOBBY_ENTER_COUPON_CODE_REQ : IMessage<SC2S_LOBBY_ENTER_COUPON_CODE_REQ>
    {
        public string Code { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_LOBBY_ENTER_COUPON_CODE_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_LOBBY_ENTER_COUPON_CODE_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_LOBBY_ENTER_COUPON_CODE_REQ message)
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

        // Implement IMessage<SC2S_LOBBY_ENTER_COUPON_CODE_REQ>
    }

    public sealed partial class SS2C_LOBBY_ENTER_COUPON_CODE_RES : IMessage<SS2C_LOBBY_ENTER_COUPON_CODE_RES>
    {
        public uint Result { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_LOBBY_ENTER_COUPON_CODE_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_LOBBY_ENTER_COUPON_CODE_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_LOBBY_ENTER_COUPON_CODE_RES message)
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

        // Implement IMessage<SS2C_LOBBY_ENTER_COUPON_CODE_RES>
    }
}
