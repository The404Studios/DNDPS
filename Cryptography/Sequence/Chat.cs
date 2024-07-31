// Generated code by the Protocol Buffers compiler. DO NOT EDIT!

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace DarkAndDarker.Cryptography.Chat
{
    public sealed partial class SCHATDATA_PIECE_ITEM_PROPERTY : IMessage<SCHATDATA_PIECE_ITEM_PROPERTY>
    {
        public const int PidFieldNumber = 1;
        private string pid_ = "";
        public string Pid
        {
            get { return pid_; }
            set { pid_ = value; }
        }

        public const int PvFieldNumber = 2;
        private int pv_;
        public int Pv
        {
            get { return pv_; }
            set { pv_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SCHATDATA_PIECE_ITEM_PROPERTY message)
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

        public bool Equals(SCHATDATA_PIECE_ITEM_PROPERTY? other)
        {
            throw new NotImplementedException();
        }

        public SCHATDATA_PIECE_ITEM_PROPERTY Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SCHATDATA_PIECE_ITEM : IMessage<SCHATDATA_PIECE_ITEM>
    {
        public const int UidFieldNumber = 1;
        private int uid_;
        public int Uid
        {
            get { return uid_; }
            set { uid_ = value; }
        }

        public const int IidFieldNumber = 2;
        private string iid_ = "";
        public string Iid
        {
            get { return iid_; }
            set { iid_ = value; }
        }

        public const int PpFieldNumber = 3;
        private static readonly FieldCodec<SCHATDATA_PIECE_ITEM_PROPERTY> _repeated_pp_codec =
            FieldCodec.ForMessage(26, SCHATDATA_PIECE_ITEM_PROPERTY.Parser);
        private readonly Google.Protobuf.Collections.RepeatedField<SCHATDATA_PIECE_ITEM_PROPERTY> pp_ = new RepeatedField<SCHATDATA_PIECE_ITEM_PROPERTY>();
        public RepeatedField<SCHATDATA_PIECE_ITEM_PROPERTY> Pp
        {
            get { return pp_; }
        }

        public const int SpFieldNumber = 4;
        private static readonly FieldCodec<SCHATDATA_PIECE_ITEM_PROPERTY> _repeated_sp_codec =
            FieldCodec.ForMessage(34, SCHATDATA_PIECE_ITEM_PROPERTY.Parser);
        private readonly RepeatedField<SCHATDATA_PIECE_ITEM_PROPERTY> sp_ = new RepeatedField<SCHATDATA_PIECE_ITEM_PROPERTY>();
        public RepeatedField<SCHATDATA_PIECE_ITEM_PROPERTY> Sp
        {
            get { return sp_; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SCHATDATA_PIECE_ITEM message)
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

        public bool Equals(SCHATDATA_PIECE_ITEM? other)
        {
            throw new NotImplementedException();
        }

        public SCHATDATA_PIECE_ITEM Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SCHATDATA_PIECE : IMessage<SCHATDATA_PIECE>
    {
        public const int ChatStrFieldNumber = 1;
        private string chatStr_ = "";
        public string ChatStr
        {
            get { return chatStr_; }
            set { chatStr_ = value; }
        }

        public const int ChatDataPieceItemFieldNumber = 2;
        private SCHATDATA_PIECE_ITEM chatDataPieceItem_;
        public SCHATDATA_PIECE_ITEM ChatDataPieceItem
        {
            get { return chatDataPieceItem_; }
            set { chatDataPieceItem_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SCHATDATA_PIECE message)
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

        public bool Equals(SCHATDATA_PIECE? other)
        {
            throw new NotImplementedException();
        }

        public SCHATDATA_PIECE Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SCHATDATA : IMessage<SCHATDATA>
    {
        public const int AccountIdFieldNumber = 1;
        private string accountId_ = "";
        public string AccountId
        {
            get { return accountId_; }
            set { accountId_ = value; }
        }

        public const int CharacterIdFieldNumber = 2;
        private string characterId_ = "";
        public string CharacterId
        {
            get { return characterId_; }
            set { characterId_ = value; }
        }

        public const int NicknameFieldNumber = 3;
        private SACCOUNT_NICKNAME nickname_;
        public SACCOUNT_NICKNAME Nickname
        {
            get { return nickname_; }
            set { nickname_ = value; }
        }

        public const int PartyIdFieldNumber = 4;
        private string partyId_ = "";
        public string PartyId
        {
            get { return partyId_; }
            set { partyId_ = value; }
        }

        public const int ChatDataPieceArrayFieldNumber = 5;
        private static readonly FieldCodec<SCHATDATA_PIECE> _repeated_chatDataPieceArray_codec =
            FieldCodec.ForMessage(42, SCHATDATA_PIECE.Parser);
        private readonly RepeatedField<SCHATDATA_PIECE> chatDataPieceArray_ = new RepeatedField<SCHATDATA_PIECE>();
        public RepeatedField<SCHATDATA_PIECE> ChatDataPieceArray
        {
            get { return chatDataPieceArray_; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SCHATDATA message)
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

        public bool Equals(SCHATDATA? other)
        {
            throw new NotImplementedException();
        }

        public SCHATDATA Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SPIECE_ITEM_BODY : IMessage<SPIECE_ITEM_BODY>
    {
        public const int IdxFieldNumber = 1;
        private int idx_;
        public int Idx
        {
            get { return idx_; }
            set { idx_ = value; }
        }

        public const int PiecesFieldNumber = 2;
        private SCHATDATA_PIECE_ITEM pieces_;
        public SCHATDATA_PIECE_ITEM Pieces
        {
            get { return pieces_; }
            set { pieces_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SPIECE_ITEM_BODY message)
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

        public bool Equals(SPIECE_ITEM_BODY? other)
        {
            throw new NotImplementedException();
        }

        public SPIECE_ITEM_BODY Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SPIECE_ITEM_ARRAY : IMessage<SPIECE_ITEM_ARRAY>
    {
        public const int LinksFieldNumber = 1;
        private static readonly FieldCodec<SPIECE_ITEM_BODY> _repeated_links_codec =
            FieldCodec.ForMessage(10, SPIECE_ITEM_BODY.Parser);
        private readonly RepeatedField<SPIECE_ITEM_BODY> links_ = new RepeatedField<SPIECE_ITEM_BODY>();
        public RepeatedField<SPIECE_ITEM_BODY> Links
        {
            get { return links_; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SPIECE_ITEM_ARRAY Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SPIECE_ITEM_ARRAY? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SPIECE_ITEM_ARRAY message)
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

        // Implement IMessage methods here
    }
}
