using DC.Packet;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace DarkAndDarker.Cryptography.Sequence.Customize
{
    public sealed partial class SC2S_CUSTOMIZE_CHARACTER_INFO_REQ : IMessage<SC2S_CUSTOMIZE_CHARACTER_INFO_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_CHARACTER_INFO_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_CHARACTER_INFO_REQ>(() => new SC2S_CUSTOMIZE_CHARACTER_INFO_REQ());
        public RepeatedField<DC.Packet.SCUSTOMIZE_CHARACTER> CustomizeCharacters { get; } = new RepeatedField<DC.Packet.SCUSTOMIZE_CHARACTER>();
        public uint LoopFlag { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_CHARACTER_INFO_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_CHARACTER_INFO_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_CHARACTER_INFO_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_CHARACTER_INFO_RES : IMessage<SS2C_CUSTOMIZE_CHARACTER_INFO_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_CHARACTER_INFO_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_CHARACTER_INFO_RES>(() => new SS2C_CUSTOMIZE_CHARACTER_INFO_RES());
        public RepeatedField<DC.Packet.SCUSTOMIZE_CHARACTER> CustomizeCharacters { get; } = new RepeatedField<SCUSTOMIZE_CHARACTER>();
        public uint LoopFlag { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_CHARACTER_INFO_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_CHARACTER_INFO_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_CHARACTER_INFO_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_ITEM_INFO_REQ : IMessage<SC2S_CUSTOMIZE_ITEM_INFO_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_ITEM_INFO_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_ITEM_INFO_REQ>(() => new SC2S_CUSTOMIZE_ITEM_INFO_REQ());
        public RepeatedField<SCUSTOMIZE_ITEM> CustomizeItems { get; } = new RepeatedField<SCUSTOMIZE_ITEM>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_ITEM_INFO_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_ITEM_INFO_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_ITEM_INFO_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_ITEM_INFO_RES : IMessage<SS2C_CUSTOMIZE_ITEM_INFO_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_ITEM_INFO_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_ITEM_INFO_RES>(() => new SS2C_CUSTOMIZE_ITEM_INFO_RES());
        public RepeatedField<SCUSTOMIZE_ITEM> CustomizeItems { get; } = new RepeatedField<SCUSTOMIZE_ITEM>();
        public uint LoopFlag { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_ITEM_INFO_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_ITEM_INFO_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_ITEM_INFO_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_EMOTE_INFO_REQ : IMessage<SC2S_CUSTOMIZE_EMOTE_INFO_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_EMOTE_INFO_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_EMOTE_INFO_REQ>(() => new SC2S_CUSTOMIZE_EMOTE_INFO_REQ());
        public RepeatedField<SEMOTE> Emotes { get; } = new RepeatedField<SEMOTE>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_EMOTE_INFO_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_EMOTE_INFO_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_EMOTE_INFO_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_EMOTE_INFO_RES : IMessage<SS2C_CUSTOMIZE_EMOTE_INFO_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_EMOTE_INFO_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_EMOTE_INFO_RES>(() => new SS2C_CUSTOMIZE_EMOTE_INFO_RES());
        public RepeatedField<SEMOTE> Emotes { get; } = new RepeatedField<SEMOTE>();
        public uint LoopFlag { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_EMOTE_INFO_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_EMOTE_INFO_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_EMOTE_INFO_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_ACTION_INFO_REQ : IMessage<SC2S_CUSTOMIZE_ACTION_INFO_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_ACTION_INFO_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_ACTION_INFO_REQ>(() => new SC2S_CUSTOMIZE_ACTION_INFO_REQ());
        public RepeatedField<SCUSTOMIZE_ACTION> CustomizeActionIds { get; } = new RepeatedField<SCUSTOMIZE_ACTION>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_ACTION_INFO_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_ACTION_INFO_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_ACTION_INFO_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_ACTION_INFO_RES : IMessage<SS2C_CUSTOMIZE_ACTION_INFO_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_ACTION_INFO_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_ACTION_INFO_RES>(() => new SS2C_CUSTOMIZE_ACTION_INFO_RES());
        public RepeatedField<SCUSTOMIZE_ACTION> CustomizeActionIds { get; } = new RepeatedField<SCUSTOMIZE_ACTION>();
        public uint LoopFlag { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_ACTION_INFO_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_ACTION_INFO_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_ACTION_INFO_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_LOBBY_EMOTE_INFO_REQ : IMessage<SC2S_CUSTOMIZE_LOBBY_EMOTE_INFO_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_LOBBY_EMOTE_INFO_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_LOBBY_EMOTE_INFO_REQ>(() => new SC2S_CUSTOMIZE_LOBBY_EMOTE_INFO_REQ());
        public RepeatedField<SCUSTOMIZE_LOBBY_EMOTE> CustomizeLobbyEmoteIds { get; } = new RepeatedField<SCUSTOMIZE_LOBBY_EMOTE>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_LOBBY_EMOTE_INFO_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_LOBBY_EMOTE_INFO_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_LOBBY_EMOTE_INFO_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_LOBBY_EMOTE_INFO_RES : IMessage<SS2C_CUSTOMIZE_LOBBY_EMOTE_INFO_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_LOBBY_EMOTE_INFO_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_LOBBY_EMOTE_INFO_RES>(() => new SS2C_CUSTOMIZE_LOBBY_EMOTE_INFO_RES());
        public RepeatedField<SCUSTOMIZE_LOBBY_EMOTE> CustomizeLobbyEmoteIds { get; } = new RepeatedField<SCUSTOMIZE_LOBBY_EMOTE>();
        public uint LoopFlag { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_LOBBY_EMOTE_INFO_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_LOBBY_EMOTE_INFO_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_LOBBY_EMOTE_INFO_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_CHARACTER_MOUNT_REQ : IMessage<SC2S_CUSTOMIZE_CHARACTER_MOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_CHARACTER_MOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_CHARACTER_MOUNT_REQ>(() => new SC2S_CUSTOMIZE_CHARACTER_MOUNT_REQ());
        public string CustomizeCharacterId { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_CHARACTER_MOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_CHARACTER_MOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_CHARACTER_MOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_CHARACTER_MOUNT_RES : IMessage<SS2C_CUSTOMIZE_CHARACTER_MOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_CHARACTER_MOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_CHARACTER_MOUNT_RES>(() => new SS2C_CUSTOMIZE_CHARACTER_MOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SCUSTOMIZE_CHARACTER> EquipCustomizeCharacters { get; } = new RepeatedField<SCUSTOMIZE_CHARACTER>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_CHARACTER_MOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_CHARACTER_MOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_CHARACTER_MOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_CHARACTER_UNMOUNT_REQ : IMessage<SC2S_CUSTOMIZE_CHARACTER_UNMOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_CHARACTER_UNMOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_CHARACTER_UNMOUNT_REQ>(() => new SC2S_CUSTOMIZE_CHARACTER_UNMOUNT_REQ());
        public string CustomizeCharacterId { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_CHARACTER_UNMOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_CHARACTER_UNMOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_CHARACTER_UNMOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_CHARACTER_UNMOUNT_RES : IMessage<SS2C_CUSTOMIZE_CHARACTER_UNMOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_CHARACTER_UNMOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_CHARACTER_UNMOUNT_RES>(() => new SS2C_CUSTOMIZE_CHARACTER_UNMOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SCUSTOMIZE_CHARACTER> EquipCustomizeCharacters { get; } = new RepeatedField<SCUSTOMIZE_CHARACTER>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_CHARACTER_UNMOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_CHARACTER_UNMOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_CHARACTER_UNMOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_ITEM_MOUNT_REQ : IMessage<SC2S_CUSTOMIZE_ITEM_MOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_ITEM_MOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_ITEM_MOUNT_REQ>(() => new SC2S_CUSTOMIZE_ITEM_MOUNT_REQ());
        public string CustomizeItemId { get; set; }
        public int EquipSlotIndex { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_ITEM_MOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_ITEM_MOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_ITEM_MOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_ITEM_MOUNT_RES : IMessage<SS2C_CUSTOMIZE_ITEM_MOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_ITEM_MOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_ITEM_MOUNT_RES>(() => new SS2C_CUSTOMIZE_ITEM_MOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SCUSTOMIZE_ITEM> EquipCustomizeItems { get; } = new RepeatedField<SCUSTOMIZE_ITEM>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_ITEM_MOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_ITEM_MOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_ITEM_MOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_ITEM_UNMOUNT_REQ : IMessage<SC2S_CUSTOMIZE_ITEM_UNMOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_ITEM_UNMOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_ITEM_UNMOUNT_REQ>(() => new SC2S_CUSTOMIZE_ITEM_UNMOUNT_REQ());
        public string CustomizeItemId { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_ITEM_UNMOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_ITEM_UNMOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_ITEM_UNMOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_ITEM_UNMOUNT_RES : IMessage<SS2C_CUSTOMIZE_ITEM_UNMOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_ITEM_UNMOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_ITEM_UNMOUNT_RES>(() => new SS2C_CUSTOMIZE_ITEM_UNMOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SCUSTOMIZE_ITEM> EquipCustomizeItems { get; } = new RepeatedField<SCUSTOMIZE_ITEM>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_ITEM_UNMOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_ITEM_UNMOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_ITEM_UNMOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_EMOTE_MOUNT_REQ : IMessage<SC2S_CUSTOMIZE_EMOTE_MOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_EMOTE_MOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_EMOTE_MOUNT_REQ>(() => new SC2S_CUSTOMIZE_EMOTE_MOUNT_REQ());
        public string EmoteId { get; set; }
        public int EquipSlotIndex { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_EMOTE_MOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_EMOTE_MOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_EMOTE_MOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_EMOTE_MOUNT_RES : IMessage<SS2C_CUSTOMIZE_EMOTE_MOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_EMOTE_MOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_EMOTE_MOUNT_RES>(() => new SS2C_CUSTOMIZE_EMOTE_MOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SEMOTE> EquipEmotes { get; } = new RepeatedField<SEMOTE>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_EMOTE_MOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_EMOTE_MOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_EMOTE_MOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_EMOTE_UNMOUNT_REQ : IMessage<SC2S_CUSTOMIZE_EMOTE_UNMOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_EMOTE_UNMOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_EMOTE_UNMOUNT_REQ>(() => new SC2S_CUSTOMIZE_EMOTE_UNMOUNT_REQ());
        public string EmoteId { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_EMOTE_UNMOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_EMOTE_UNMOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_EMOTE_UNMOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_EMOTE_UNMOUNT_RES : IMessage<SS2C_CUSTOMIZE_EMOTE_UNMOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_EMOTE_UNMOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_EMOTE_UNMOUNT_RES>(() => new SS2C_CUSTOMIZE_EMOTE_UNMOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SEMOTE> EquipEmotes { get; } = new RepeatedField<SEMOTE>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_EMOTE_UNMOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_EMOTE_UNMOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_EMOTE_UNMOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_ACTION_MOUNT_REQ : IMessage<SC2S_CUSTOMIZE_ACTION_MOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_ACTION_MOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_ACTION_MOUNT_REQ>(() => new SC2S_CUSTOMIZE_ACTION_MOUNT_REQ());
        public string CustomizeActionId { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_ACTION_MOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_ACTION_MOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_ACTION_MOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_ACTION_MOUNT_RES : IMessage<SS2C_CUSTOMIZE_ACTION_MOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_ACTION_MOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_ACTION_MOUNT_RES>(() => new SS2C_CUSTOMIZE_ACTION_MOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SCUSTOMIZE_ACTION> EquipCustomizeActionIds { get; } = new RepeatedField<SCUSTOMIZE_ACTION>();

        MessageDescriptor IMessage.Descriptor => throw new NotImplementedException();

        int IMessage.CalculateSize()
        {
            throw new NotImplementedException();
        }

        SS2C_CUSTOMIZE_ACTION_MOUNT_RES IDeepCloneable<SS2C_CUSTOMIZE_ACTION_MOUNT_RES>.Clone()
        {
            throw new NotImplementedException();
        }

        bool IEquatable<SS2C_CUSTOMIZE_ACTION_MOUNT_RES>.Equals(SS2C_CUSTOMIZE_ACTION_MOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        void IMessage<SS2C_CUSTOMIZE_ACTION_MOUNT_RES>.MergeFrom(SS2C_CUSTOMIZE_ACTION_MOUNT_RES message)
        {
            throw new NotImplementedException();
        }

        void IMessage.MergeFrom(CodedInputStream input)
        {
            throw new NotImplementedException();
        }

        void IMessage.WriteTo(CodedOutputStream output)
        {
            throw new NotImplementedException();
        }

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ : IMessage<SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ>(() => new SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ());
        public string CustomizeActionId { get; set; }

        MessageDescriptor IMessage.Descriptor => throw new NotImplementedException();

        int IMessage.CalculateSize()
        {
            throw new NotImplementedException();
        }

        SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ IDeepCloneable<SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ>.Clone()
        {
            throw new NotImplementedException();
        }

        bool IEquatable<SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ>.Equals(SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        void IMessage<SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ>.MergeFrom(SC2S_CUSTOMIZE_ACTION_UNMOUNT_REQ message)
        {
            throw new NotImplementedException();
        }

        void IMessage.MergeFrom(CodedInputStream input)
        {
            throw new NotImplementedException();
        }

        void IMessage.WriteTo(CodedOutputStream output)
        {
            throw new NotImplementedException();
        }

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_ACTION_UNMOUNT_RES : IMessage<SS2C_CUSTOMIZE_ACTION_UNMOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_ACTION_UNMOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_ACTION_UNMOUNT_RES>(() => new SS2C_CUSTOMIZE_ACTION_UNMOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SCUSTOMIZE_ACTION> EquipCustomizeActionIds { get; } = new RepeatedField<SCUSTOMIZE_ACTION>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_ACTION_UNMOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_ACTION_UNMOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_ACTION_UNMOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_LOBBY_EMOTE_MOUNT_REQ : IMessage<SC2S_CUSTOMIZE_LOBBY_EMOTE_MOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_LOBBY_EMOTE_MOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_LOBBY_EMOTE_MOUNT_REQ>(() => new SC2S_CUSTOMIZE_LOBBY_EMOTE_MOUNT_REQ());
        public string CustomizeLobbyEmoteId { get; set; }
        public int EquipSlotIndex { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_LOBBY_EMOTE_MOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_LOBBY_EMOTE_MOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_LOBBY_EMOTE_MOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_LOBBY_EMOTE_MOUNT_RES : IMessage<SS2C_CUSTOMIZE_LOBBY_EMOTE_MOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_LOBBY_EMOTE_MOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_LOBBY_EMOTE_MOUNT_RES>(() => new SS2C_CUSTOMIZE_LOBBY_EMOTE_MOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SCUSTOMIZE_LOBBY_EMOTE> EquipCustomizeLobbyEmoteIds { get; } = new RepeatedField<SCUSTOMIZE_LOBBY_EMOTE>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_LOBBY_EMOTE_MOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_LOBBY_EMOTE_MOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_LOBBY_EMOTE_MOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_REQ : IMessage<SC2S_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_REQ>(() => new SC2S_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_REQ());
        public string CustomizeLobbyEmoteId { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_RES : IMessage<SS2C_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_RES>(() => new SS2C_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_RES());
        public uint Result { get; set; }
        public RepeatedField<SCUSTOMIZE_LOBBY_EMOTE> EquipCustomizeLobbyEmoteIds { get; } = new RepeatedField<SCUSTOMIZE_LOBBY_EMOTE>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_LOBBY_EMOTE_UNMOUNT_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SC2S_CUSTOMIZE_NEW_ITEM_CHECK_REQ : IMessage<SC2S_CUSTOMIZE_NEW_ITEM_CHECK_REQ>
    {
        public static readonly MessageParser<SC2S_CUSTOMIZE_NEW_ITEM_CHECK_REQ> Parser = new MessageParser<SC2S_CUSTOMIZE_NEW_ITEM_CHECK_REQ>(() => new SC2S_CUSTOMIZE_NEW_ITEM_CHECK_REQ());
        public string ItemId { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_CUSTOMIZE_NEW_ITEM_CHECK_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_CUSTOMIZE_NEW_ITEM_CHECK_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_CUSTOMIZE_NEW_ITEM_CHECK_REQ message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_NEW_ITEM_CHECK_RES : IMessage<SS2C_CUSTOMIZE_NEW_ITEM_CHECK_RES>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_NEW_ITEM_CHECK_RES> Parser = new MessageParser<SS2C_CUSTOMIZE_NEW_ITEM_CHECK_RES>(() => new SS2C_CUSTOMIZE_NEW_ITEM_CHECK_RES());

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_NEW_ITEM_CHECK_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_NEW_ITEM_CHECK_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_NEW_ITEM_CHECK_RES message)
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

        // Implementation of IMessage methods
    }

    public sealed partial class SS2C_CUSTOMIZE_NEW_ITEM_ALERT_NOT : IMessage<SS2C_CUSTOMIZE_NEW_ITEM_ALERT_NOT>
    {
        public static readonly MessageParser<SS2C_CUSTOMIZE_NEW_ITEM_ALERT_NOT> Parser = new MessageParser<SS2C_CUSTOMIZE_NEW_ITEM_ALERT_NOT>(() => new SS2C_CUSTOMIZE_NEW_ITEM_ALERT_NOT());

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CUSTOMIZE_NEW_ITEM_ALERT_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CUSTOMIZE_NEW_ITEM_ALERT_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CUSTOMIZE_NEW_ITEM_ALERT_NOT message)
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

        // Implementation of IMessage methods
    }

    // Definitions for SCUSTOMIZE_CHARACTER, SCUSTOMIZE_ITEM, SEMOTE, SCUSTOMIZE_ACTION, SCUSTOMIZE_LOBBY_EMOTE
    // You should also define these classes based on their specifications in your .proto file
}
