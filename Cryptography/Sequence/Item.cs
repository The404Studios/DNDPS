// _Item.cs

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace DC.Packet
{
    public sealed partial class SItemMeta : IMessage<SItemMeta>
    {
        public string SoulHeart_AccountId { get; set; }
        public string SoulHeart_PartyId { get; set; }
        public string SoulHeart_NickName_origin { get; set; }
        public string SoulHeart_NickName_streaming { get; set; }
        public uint AvailableValue { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SItemMeta Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SItemMeta? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SItemMeta message)
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

        // Implement IMessage<SItemMeta>
    }

    public sealed partial class SDownItem : IMessage<SDownItem>
    {
        public ulong ItemUniqueId { get; set; }
        public string ItemId { get; set; }
        public uint ItemCount { get; set; }
        public uint InventoryId { get; set; }
        public uint SlotId { get; set; }
        public uint BEquipped { get; set; }
        public uint ItemAmmoCount { get; set; }
        public uint ItemContentsCount { get; set; }
        public SItemMeta MetaItem { get; set; }
        public RepeatedField<SItemProperty> PrimaryPropertyArray { get; } = new RepeatedField<SItemProperty>();
        public RepeatedField<SItemProperty> SecondaryPropertyArray { get; } = new RepeatedField<SItemProperty>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SDownItem Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SDownItem? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SDownItem message)
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

        // Implement IMessage<SDownItem>
    }

    public sealed partial class SItem : IMessage<SItem>
    {
        public ulong ItemUniqueId { get; set; }
        public string ItemId { get; set; }
        public uint ItemCount { get; set; }
        public uint InventoryId { get; set; }
        public uint SlotId { get; set; }
        public uint ItemAmmoCount { get; set; }
        public uint ItemContentsCount { get; set; }
        public RepeatedField<SItemProperty> PrimaryPropertyArray { get; } = new RepeatedField<SItemProperty>();
        public RepeatedField<SItemProperty> SecondaryPropertyArray { get; } = new RepeatedField<SItemProperty>();

        // Implement IMessage<SItem>
    }

    public sealed partial class SItemProperty : IMessage<SItemProperty>
    {
        public string PropertyTypeId { get; set; }
        public int PropertyValue { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SItemProperty Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SItemProperty? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SItemProperty message)
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

        // Implement IMessage<SItemProperty>
    }

    public sealed partial class SItems : IMessage<SItems>
    {
        public RepeatedField<SItem> Item { get; } = new RepeatedField<SItem>();

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SItems Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SItems? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SItems message)
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

        // Implement IMessage<SItems>
    }

    public sealed partial class SPerk : IMessage<SPerk>
    {
        public uint Index { get; set; }
        public string PerkId { get; set; }

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

        // Implement IMessage<SPerk>
    }

    public sealed partial class SSkill : IMessage<SSkill>
    {
        public uint Index { get; set; }
        public string SkillId { get; set; }

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

        // Implement IMessage<SSkill>
    }

    public sealed partial class SSpell : IMessage<SSpell>
    {
        public uint SlotIndex { get; set; }
        public uint SequenceIndex { get; set; }
        public string SpellId { get; set; }

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

        // Implement IMessage<SSpell>
    }

    public sealed partial class SCUSTOMIZE_CHARACTER : IMessage<SCUSTOMIZE_CHARACTER>
    {
        public string CustomizeCharacterId { get; set; }
        public bool IsEquip { get; set; }
        public bool IsNew { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SCUSTOMIZE_CHARACTER Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SCUSTOMIZE_CHARACTER? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SCUSTOMIZE_CHARACTER message)
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

        // Implement IMessage<SCUSTOMIZE_CHARACTER>
    }

    public sealed partial class SCUSTOMIZE_ITEM : IMessage<SCUSTOMIZE_ITEM>
    {
        public string CustomizeItemId { get; set; }
        public bool IsEquip { get; set; }
        public bool IsNew { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SCUSTOMIZE_ITEM Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SCUSTOMIZE_ITEM? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SCUSTOMIZE_ITEM message)
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

        // Implement IMessage<SCUSTOMIZE_ITEM>
    }

    public sealed partial class SEMOTE : IMessage<SEMOTE>
    {
        public string EmoteId { get; set; }
        public uint EquipSlotIndex { get; set; }
        public bool IsNew { get; set; }

        MessageDescriptor IMessage.Descriptor => throw new NotImplementedException();

        int IMessage.CalculateSize()
        {
            throw new NotImplementedException();
        }

        SEMOTE IDeepCloneable<SEMOTE>.Clone()
        {
            throw new NotImplementedException();
        }

        bool IEquatable<SEMOTE>.Equals(SEMOTE? other)
        {
            throw new NotImplementedException();
        }

        void IMessage<SEMOTE>.MergeFrom(SEMOTE message)
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

        // Implement IMessage<SEMOTE>
    }

    public sealed partial class SCUSTOMIZE_ACTION : IMessage<SCUSTOMIZE_ACTION>
    {
        public string CustomizeActionId { get; set; }
        public bool IsEquip { get; set; }
        public bool IsNew { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SCUSTOMIZE_ACTION Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SCUSTOMIZE_ACTION? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SCUSTOMIZE_ACTION message)
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

        // Implement IMessage<SCUSTOMIZE_ACTION>
    }

    public sealed partial class SCUSTOMIZE_LOBBY_EMOTE : IMessage<SCUSTOMIZE_LOBBY_EMOTE>
    {
        public string LobbyEmoteId { get; set; }
        public uint EquipSlotIndex { get; set; }
        public bool IsNew { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SCUSTOMIZE_LOBBY_EMOTE Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SCUSTOMIZE_LOBBY_EMOTE? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SCUSTOMIZE_LOBBY_EMOTE message)
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

        // Implement IMessage<SCUSTOMIZE_LOBBY_EMOTE>
    }
}
