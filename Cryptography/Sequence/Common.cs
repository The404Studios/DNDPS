// Generated code by the Protocol Buffers compiler. DO NOT EDIT!

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace DarkAndDarker.Cryptography.Sequence.Common
{
    public sealed partial class SC2S_META_LOCATION_REQ : IMessage<SC2S_META_LOCATION_REQ>
    {
        public const int LocationFieldNumber = 1;
        private int location_;
        public int Location
        {
            get { return location_; }
            set { location_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_META_LOCATION_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_META_LOCATION_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_META_LOCATION_REQ message)
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

    public sealed partial class SS2C_META_LOCATION_RES : IMessage<SS2C_META_LOCATION_RES>
    {
        public const int LocationFieldNumber = 1;
        private int location_;
        public int Location
        {
            get { return location_; }
            set { location_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_META_LOCATION_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_META_LOCATION_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_META_LOCATION_RES message)
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

    public sealed partial class SC2S_BLOCK_CHARACTER_REQ : IMessage<SC2S_BLOCK_CHARACTER_REQ>
    {
        public const int TargetAccountIdFieldNumber = 1;
        private string targetAccountId_ = "";
        public string TargetAccountId
        {
            get { return targetAccountId_; }
            set { targetAccountId_ = value; }
        }

        public const int TargetCharacterIdFieldNumber = 2;
        private string targetCharacterId_ = "";
        public string TargetCharacterId
        {
            get { return targetCharacterId_; }
            set { targetCharacterId_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SC2S_BLOCK_CHARACTER_REQ message)
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

        public bool Equals(SC2S_BLOCK_CHARACTER_REQ? other)
        {
            throw new NotImplementedException();
        }

        public SC2S_BLOCK_CHARACTER_REQ Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SS2C_BLOCK_CHARACTER_RES : IMessage<SS2C_BLOCK_CHARACTER_RES>
    {
        public const int ResultFieldNumber = 1;
        private int result_;
        public int Result
        {
            get { return result_; }
            set { result_ = value; }
        }

        public const int TargetCharacterInfoFieldNumber = 2;
        private SBLOCK_CHARACTER targetCharacterInfo_;
        public SBLOCK_CHARACTER TargetCharacterInfo
        {
            get { return targetCharacterInfo_; }
            set { targetCharacterInfo_ = value; }
        }

        // Implement IMessage methods here
    }

    public sealed partial class SC2S_UNBLOCK_CHARACTER_REQ : IMessage<SC2S_UNBLOCK_CHARACTER_REQ>
    {
        public const int TargetAccountIdFieldNumber = 1;
        private string targetAccountId_ = "";
        public string TargetAccountId
        {
            get { return targetAccountId_; }
            set { targetAccountId_ = value; }
        }

        public const int TargetCharacterIdFieldNumber = 2;
        private string targetCharacterId_ = "";
        public string TargetCharacterId
        {
            get { return targetCharacterId_; }
            set { targetCharacterId_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SC2S_UNBLOCK_CHARACTER_REQ message)
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

        public bool Equals(SC2S_UNBLOCK_CHARACTER_REQ? other)
        {
            throw new NotImplementedException();
        }

        public SC2S_UNBLOCK_CHARACTER_REQ Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SS2C_UNBLOCK_CHARACTER_RES : IMessage<SS2C_UNBLOCK_CHARACTER_RES>
    {
        public const int ResultFieldNumber = 1;
        private int result_;
        public int Result
        {
            get { return result_; }
            set { result_ = value; }
        }

        public const int TargetCharacterIdFieldNumber = 2;
        private string targetCharacterId_ = "";
        public string TargetCharacterId
        {
            get { return targetCharacterId_; }
            set { targetCharacterId_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SS2C_UNBLOCK_CHARACTER_RES message)
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

        public bool Equals(SS2C_UNBLOCK_CHARACTER_RES? other)
        {
            throw new NotImplementedException();
        }

        public SS2C_UNBLOCK_CHARACTER_RES Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SC2S_BLOCK_CHARACTER_LIST_REQ : IMessage<SC2S_BLOCK_CHARACTER_LIST_REQ>
    {
        // This message has no fields
        // Implement IMessage methods here
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_BLOCK_CHARACTER_LIST_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_BLOCK_CHARACTER_LIST_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_BLOCK_CHARACTER_LIST_REQ message)
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

    public sealed partial class SS2C_BLOCK_CHARACTER_LIST_RES : IMessage<SS2C_BLOCK_CHARACTER_LIST_RES>
    {
        public const int BlockCharactersFieldNumber = 1;
        private static readonly FieldCodec<SBLOCK_CHARACTER> _repeated_blockCharacters_codec =
            FieldCodec.ForMessage(10, SBLOCK_CHARACTER.Parser);
        private readonly RepeatedField<SBLOCK_CHARACTER> blockCharacters_ = new RepeatedField<SBLOCK_CHARACTER>();
        public RepeatedField<SBLOCK_CHARACTER> BlockCharacters
        {
            get { return blockCharacters_; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_BLOCK_CHARACTER_LIST_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_BLOCK_CHARACTER_LIST_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_BLOCK_CHARACTER_LIST_RES message)
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

    public sealed partial class SC2S_HACK_LOG_REQ : IMessage<SC2S_HACK_LOG_REQ>
    {
        public const int LogMessageFieldNumber = 1;
        private string logMessage_ = "";
        public string LogMessage
        {
            get { return logMessage_; }
            set { logMessage_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_HACK_LOG_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_HACK_LOG_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_HACK_LOG_REQ message)
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

    public sealed partial class SS2C_HACK_LOG_RES : IMessage<SS2C_HACK_LOG_RES>
    {
        // This message has no fields
        // Implement IMessage methods here
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_HACK_LOG_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_HACK_LOG_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_HACK_LOG_RES message)
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

    public sealed partial class SANNOUNCE_MESSAGE : IMessage<SANNOUNCE_MESSAGE>
    {
        public const int NationTypeFieldNumber = 1;
        private int nationType_;
        public int NationType
        {
            get { return nationType_; }
            set { nationType_ = value; }
        }

        public const int AnnounceMessageFieldNumber = 2;
        private string announceMessage_ = "";
        public string AnnounceMessage
        {
            get { return announceMessage_; }
            set { announceMessage_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SANNOUNCE_MESSAGE message)
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

        public bool Equals(SANNOUNCE_MESSAGE? other)
        {
            throw new NotImplementedException();
        }

        public SANNOUNCE_MESSAGE Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SS2C_OPERATE_ANNOUNCE_NOT : IMessage<SS2C_OPERATE_ANNOUNCE_NOT>
    {
        public const int AnnounceListFieldNumber = 1;
        private static readonly FieldCodec<SANNOUNCE_MESSAGE> _repeated_announceList_codec =
            FieldCodec.ForMessage(10, SANNOUNCE_MESSAGE.Parser);
        private readonly RepeatedField<SANNOUNCE_MESSAGE> announceList_ = new RepeatedField<SANNOUNCE_MESSAGE>();
        public RepeatedField<SANNOUNCE_MESSAGE> AnnounceList
        {
            get { return announceList_; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_OPERATE_ANNOUNCE_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_OPERATE_ANNOUNCE_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_OPERATE_ANNOUNCE_NOT message)
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

    public sealed partial class FSERVICE_POLICY : IMessage<FSERVICE_POLICY>
    {
        public const int PolicyTypeFieldNumber = 1;
        private int policyType_;
        public int PolicyType
        {
            get { return policyType_; }
            set { policyType_ = value; }
        }

        public const int PolicyValueFieldNumber = 2;
        private int policyValue_;
        public int PolicyValue
        {
            get { return policyValue_; }
            set { policyValue_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(FSERVICE_POLICY message)
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

        public bool Equals(FSERVICE_POLICY? other)
        {
            throw new NotImplementedException();
        }

        public FSERVICE_POLICY Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SS2C_SERVICE_POLICY_NOT : IMessage<SS2C_SERVICE_POLICY_NOT>
    {
        public const int PolicyListFieldNumber = 1;
        private static readonly FieldCodec<FSERVICE_POLICY> _repeated_policyList_codec =
            FieldCodec.ForMessage(10, FSERVICE_POLICY.Parser);
        private readonly RepeatedField<FSERVICE_POLICY> policyList_ = new RepeatedField<FSERVICE_POLICY>();
        public RepeatedField<FSERVICE_POLICY> PolicyList
        {
            get { return policyList_; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_SERVICE_POLICY_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_SERVICE_POLICY_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_SERVICE_POLICY_NOT message)
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

    public sealed partial class SC2S_RE_LOGIN_REQ : IMessage<SC2S_RE_LOGIN_REQ>
    {
        // This message has no fields
        // Implement IMessage methods here
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_RE_LOGIN_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_RE_LOGIN_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_RE_LOGIN_REQ message)
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

    public sealed partial class SS2C_RE_LOGIN_RES : IMessage<SS2C_RE_LOGIN_RES>
    {
        public const int IsReconnectFieldNumber = 1;
        private int isReconnect_;
        public int IsReconnect
        {
            get { return isReconnect_; }
            set { isReconnect_ = value; }
        }

        public const int AddressFieldNumber = 2;
        private string address_ = "";
        public string Address
        {
            get { return address_; }
            set { address_ = value; }
        }

        public const int SessionIdFieldNumber = 3;
        private string sessionId_ = "";
        public string SessionId
        {
            get { return sessionId_; }
            set { sessionId_ = value; }
        }

        public const int AccountIdFieldNumber = 4;
        private string accountId_ = "";
        public string AccountId
        {
            get { return accountId_; }
            set { accountId_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SS2C_RE_LOGIN_RES message)
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

        public bool Equals(SS2C_RE_LOGIN_RES? other)
        {
            throw new NotImplementedException();
        }

        public SS2C_RE_LOGIN_RES Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SS2C_CLOSED_GAME_NOT : IMessage<SS2C_CLOSED_GAME_NOT>
    {
        public const int CyzzFieldNumber = 1;
        private int cyzz_;
        public int Cyzz
        {
            get { return cyzz_; }
            set { cyzz_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_CLOSED_GAME_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_CLOSED_GAME_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_CLOSED_GAME_NOT message)
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

    public sealed partial class SS2C_HACK_CHECK_DLL_LIST_NOT : IMessage<SS2C_HACK_CHECK_DLL_LIST_NOT>
    {
        public const int DllListFieldNumber = 1;
        private static readonly FieldCodec<string> _repeated_dllList_codec =
            FieldCodec.ForString(10);
        private readonly RepeatedField<string> dllList_ = new RepeatedField<string>();
        public RepeatedField<string> DllList
        {
            get { return dllList_; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_HACK_CHECK_DLL_LIST_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_HACK_CHECK_DLL_LIST_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_HACK_CHECK_DLL_LIST_NOT message)
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

    public sealed partial class SC2S_USER_CHARACTER_INFO_REQ : IMessage<SC2S_USER_CHARACTER_INFO_REQ>
    {
        public const int CallbackTypeFieldNumber = 1;
        private int callbackType_;
        public int CallbackType
        {
            get { return callbackType_; }
            set { callbackType_ = value; }
        }

        public const int ReportIdFieldNumber = 2;
        private string reportId_ = "";
        public string ReportId
        {
            get { return reportId_; }
            set { reportId_ = value; }
        }

        public const int HIdsFieldNumber = 3;
        private static readonly FieldCodec<string> _repeated_hIds_codec =
            FieldCodec.ForString(26);
        private readonly RepeatedField<string> hIds_ = new RepeatedField<string>();
        public RepeatedField<string> HIds
        {
            get { return hIds_; }
        }

        public const int BlobFieldNumber = 4;
        private static readonly FieldCodec<int> _repeated_blob_codec =
            FieldCodec.ForInt32(34);
        private readonly RepeatedField<int> blob_ = new RepeatedField<int>();
        public RepeatedField<int> Blob
        {
            get { return blob_; }
        }

        public const int AccountIdFieldNumber = 5;
        private string accountId_ = "";
        public string AccountId
        {
            get { return accountId_; }
            set { accountId_ = value; }
        }

        public const int CharacterIdFieldNumber = 6;
        private string characterId_ = "";
        public string CharacterId
        {
            get { return characterId_; }
            set { characterId_ = value; }
        }

        public const int OriginNicknameFieldNumber = 7;
        private string originNickname_ = "";
        public string OriginNickname
        {
            get { return originNickname_; }
            set { originNickname_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SC2S_USER_CHARACTER_INFO_REQ message)
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

        public bool Equals(SC2S_USER_CHARACTER_INFO_REQ? other)
        {
            throw new NotImplementedException();
        }

        public SC2S_USER_CHARACTER_INFO_REQ Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SS2C_USER_CHARACTER_INFO_RES : IMessage<SS2C_USER_CHARACTER_INFO_RES>
    {
        // This message has no fields
        // Implement IMessage methods here
        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_USER_CHARACTER_INFO_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_USER_CHARACTER_INFO_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_USER_CHARACTER_INFO_RES message)
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

    public sealed partial class SC2S_GM_ENTER_GAME_SPECTATOR_REQ : IMessage<SC2S_GM_ENTER_GAME_SPECTATOR_REQ>
    {
        public const int NicknameFieldNumber = 1;
        private string nickname_ = "";
        public string Nickname
        {
            get { return nickname_; }
            set { nickname_ = value; }
        }

        public const int AccountIdFieldNumber = 2;
        private string accountId_ = "";
        public string AccountId
        {
            get { return accountId_; }
            set { accountId_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SC2S_GM_ENTER_GAME_SPECTATOR_REQ message)
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

        public bool Equals(SC2S_GM_ENTER_GAME_SPECTATOR_REQ? other)
        {
            throw new NotImplementedException();
        }

        public SC2S_GM_ENTER_GAME_SPECTATOR_REQ Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }

    public sealed partial class SS2C_GM_ENTER_GAME_SPECTATOR_RES : IMessage<SS2C_GM_ENTER_GAME_SPECTATOR_RES>
    {
        public const int ResultFieldNumber = 1;
        private int result_;
        public int Result
        {
            get { return result_; }
            set { result_ = value; }
        }

        public const int IpFieldNumber = 2;
        private string ip_ = "";
        public string Ip
        {
            get { return ip_; }
            set { ip_ = value; }
        }

        public const int PortFieldNumber = 3;
        private int port_;
        public int Port
        {
            get { return port_; }
            set { port_ = value; }
        }

        public const int TokenFieldNumber = 4;
        private string token_ = "";
        public string Token
        {
            get { return token_; }
            set { token_ = value; }
        }

        public const int ServiceUrlFieldNumber = 5;
        private string serviceUrl_ = "";
        public string ServiceUrl
        {
            get { return serviceUrl_; }
            set { serviceUrl_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SS2C_GM_ENTER_GAME_SPECTATOR_RES message)
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

        public bool Equals(SS2C_GM_ENTER_GAME_SPECTATOR_RES? other)
        {
            throw new NotImplementedException();
        }

        public SS2C_GM_ENTER_GAME_SPECTATOR_RES Clone()
        {
            throw new NotImplementedException();
        }

        // Implement IMessage methods here
    }
}
