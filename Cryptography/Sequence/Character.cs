// Generated code by the Protocol Buffers compiler. DO NOT EDIT!

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace DC.Packet
{
    public sealed partial class SCHARACTER_INFO : IMessage<SCHARACTER_INFO>
    {
        public const int AccountIdFieldNumber = 1;
        private string accountId_ = "";
        public string AccountId
        {
            get { return accountId_; }
            set { accountId_ = value; }
        }

        public const int NickNameFieldNumber = 2;
        private SACCOUNT_NICKNAME nickName_;
        public SACCOUNT_NICKNAME NickName
        {
            get { return nickName_; }
            set { nickName_ = value; }
        }

        public const int CharacterClassFieldNumber = 3;
        private string characterClass_ = "";
        public string CharacterClass
        {
            get { return characterClass_; }
            set { characterClass_ = value; }
        }

        public const int CharacterIdFieldNumber = 4;
        private string characterId_ = "";
        public string CharacterId
        {
            get { return characterId_; }
            set { characterId_ = value; }
        }

        public const int GenderFieldNumber = 5;
        private int gender_;
        public int Gender
        {
            get { return gender_; }
            set { gender_ = value; }
        }

        public const int LevelFieldNumber = 6;
        private int level_;
        public int Level
        {
            get { return level_; }
            set { level_ = value; }
        }

        public const int ServiceGrpcFieldNumber = 7;
        private string serviceGrpc_ = "";
        public string ServiceGrpc
        {
            get { return serviceGrpc_; }
            set { serviceGrpc_ = value; }
        }

        public const int CharacterItemListFieldNumber = 8;
        private static readonly RepeatedField<SItem> characterItemList_ = new RepeatedField<SItem>();
        public RepeatedField<SItem> CharacterItemList
        {
            get { return characterItemList_; }
        }

        public const int CharacterStorageItemListFieldNumber = 9;
        private static readonly RepeatedField<SItem> characterStorageItemList_ = new RepeatedField<SItem>();
        public RepeatedField<SItem> CharacterStorageItemList
        {
            get { return characterStorageItemList_; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SCHARACTER_INFO message)
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

        public bool Equals(SCHARACTER_INFO? other)
        {
            throw new NotImplementedException();
        }

        public SCHARACTER_INFO Clone()
        {
            throw new NotImplementedException();
        }

        // Implement Message methods here idk
    }

    public sealed partial class SCHARACTER_FRIEND_INFO : IMessage<SCHARACTER_FRIEND_INFO>
    {
        public const int AccountIdFieldNumber = 1;
        private string accountId_ = "";
        public string AccountId
        {
            get { return accountId_; }
            set { accountId_ = value; }
        }

        public const int NickNameFieldNumber = 2;
        private SACCOUNT_NICKNAME nickName_;
        public SACCOUNT_NICKNAME NickName
        {
            get { return nickName_; }
            set { nickName_ = value; }
        }

        public const int CharacterClassFieldNumber = 3;
        private string characterClass_ = "";
        public string CharacterClass
        {
            get { return characterClass_; }
            set { characterClass_ = value; }
        }

        public const int CharacterIdFieldNumber = 4;
        private string characterId_ = "";
        public string CharacterId
        {
            get { return characterId_; }
            set { characterId_ = value; }
        }

        public const int GenderFieldNumber = 5;
        private int gender_;
        public int Gender
        {
            get { return gender_; }
            set { gender_ = value; }
        }

        public const int LevelFieldNumber = 6;
        private int level_;
        public int Level
        {
            get { return level_; }
            set { level_ = value; }
        }

        public const int LocationStatusFieldNumber = 7;
        private int locationStatus_;
        public int LocationStatus
        {
            get { return locationStatus_; }
            set { locationStatus_ = value; }
        }

        public const int PartyMemberCountFieldNumber = 8;
        private int partyMemberCount_;
        public int PartyMemberCount
        {
            get { return partyMemberCount_; }
            set { partyMemberCount_ = value; }
        }

        public const int PartyMaxMemberCountFieldNumber = 9;
        private int partyMaxMemberCount_;
        public int PartyMaxMemberCount
        {
            get { return partyMaxMemberCount_; }
            set { partyMaxMemberCount_ = value; }
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public void MergeFrom(SCHARACTER_FRIEND_INFO message)
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

        public bool Equals(SCHARACTER_FRIEND_INFO? other)
        {
            throw new NotImplementedException();
        }

        public SCHARACTER_FRIEND_INFO Clone()
        {
            throw new NotImplementedException();
        }
    }

    public enum FriendLocation
    {
        FriendLocationNone = 0,
        FriendLocationLobby = 1,
        FriendLocationDungeon = 2,
        FriendLocationOffline = 3
    }

   // match making.
}
