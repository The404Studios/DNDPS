using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System.Collections.Generic;

namespace DC.Packet
{
    public sealed partial class SC2S_PARTY_INVITE_REQ : IMessage<SC2S_PARTY_INVITE_REQ>
    {
        public const int FindNickNameFieldNumber = 1;
        public const int FindAccountIdFieldNumber = 2;
        public const int FindCharacterIdFieldNumber = 3;

        private SCACCOUNT_NICKNAME findNickName_;
        private string findAccountId_ = "";
        private string findCharacterId_ = "";

        public SCACCOUNT_NICKNAME FindNickName
        {
            get => findNickName_;
            set => findNickName_ = value;
        }

        public string FindAccountId
        {
            get => findAccountId_;
            set => findAccountId_ = value;
        }

        public string FindCharacterId
        {
            get => findCharacterId_;
            set => findCharacterId_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_PARTY_INVITE_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_PARTY_INVITE_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_PARTY_INVITE_REQ message)
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

    public sealed partial class SS2C_PARTY_INVITE_RES : IMessage<SS2C_PARTY_INVITE_RES>
    {
        public const int ResultFieldNumber = 1;
        private uint result_;

        public uint Result
        {
            get => result_;
            set => result_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_PARTY_INVITE_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_PARTY_INVITE_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_PARTY_INVITE_RES message)
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

    public sealed partial class SS2C_PARTY_INVITE_NOT : IMessage<SS2C_PARTY_INVITE_NOT>
    {
        public const int InviteeNickNameFieldNumber = 1;
        public const int InviteeAccountIdFieldNumber = 2;
        public const int InviteeCharacterIdFieldNumber = 3;

        private SCACCOUNT_NICKNAME inviteeNickName_;
        private string inviteeAccountId_ = "";
        private string inviteeCharacterId_ = "";

        public SCACCOUNT_NICKNAME InviteeNickName
        {
            get => inviteeNickName_;
            set => inviteeNickName_ = value;
        }

        public string InviteeAccountId
        {
            get => inviteeAccountId_;
            set => inviteeAccountId_ = value;
        }

        public string InviteeCharacterId
        {
            get => inviteeCharacterId_;
            set => inviteeCharacterId_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_PARTY_INVITE_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_PARTY_INVITE_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_PARTY_INVITE_NOT message)
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

    public sealed partial class SC2S_PARTY_INVITE_ANSWER_REQ : IMessage<SC2S_PARTY_INVITE_ANSWER_REQ>
    {
        public const int InviteResultFieldNumber = 1;
        public const int ReturnAccountIdFieldNumber = 2;

        private uint inviteResult_;
        private string returnAccountId_ = "";

        public uint InviteResult
        {
            get => inviteResult_;
            set => inviteResult_ = value;
        }

        public string ReturnAccountId
        {
            get => returnAccountId_;
            set => returnAccountId_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SC2S_PARTY_INVITE_ANSWER_REQ Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SC2S_PARTY_INVITE_ANSWER_REQ? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SC2S_PARTY_INVITE_ANSWER_REQ message)
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

    public sealed partial class SS2C_PARTY_INVITE_ANSWER_RES : IMessage<SS2C_PARTY_INVITE_ANSWER_RES>
    {
        public const int ResultFieldNumber = 1;
        private uint result_;

        public uint Result
        {
            get => result_;
            set => result_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_PARTY_INVITE_ANSWER_RES Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_PARTY_INVITE_ANSWER_RES? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_PARTY_INVITE_ANSWER_RES message)
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

    public sealed partial class SS2C_PARTY_INVITE_ANSWER_RESULT_NOT : IMessage<SS2C_PARTY_INVITE_ANSWER_RESULT_NOT>
    {
        public const int NickNameFieldNumber = 1;
        public const int InviteResultFieldNumber = 2;

        private SCACCOUNT_NICKNAME nickName_;
        private uint inviteResult_;

        public SCACCOUNT_NICKNAME NickName
        {
            get => nickName_;
            set => nickName_ = value;
        }

        public uint InviteResult
        {
            get => inviteResult_;
            set => inviteResult_ = value;
        }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public SS2C_PARTY_INVITE_ANSWER_RESULT_NOT Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(SS2C_PARTY_INVITE_ANSWER_RESULT_NOT? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(SS2C_PARTY_INVITE_ANSWER_RESULT_NOT message)
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

    public enum PARTY_INVITE_ANSWER
    {
        INVITE_ANSWER_NONE = 0,
        INVITE_ANSWER_ACCEPT = 1,
        INVITE_ANSWER_CANCEL = 2
    }

    // Define other classes and enums similarly...
}
