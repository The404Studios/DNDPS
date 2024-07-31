// IronMace.cs

using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace DC.Packet
{
    public sealed partial class IronMace_Login : IMessage<IronMace_Login>
    {
        public string LoginId { get; set; }
        public string Password { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public IronMace_Login Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(IronMace_Login? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(IronMace_Login message)
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

        // Implement IMessage<IronMace_Login>
    }

    public sealed partial class IronMace_Login_Res : IMessage<IronMace_Login_Res>
    {
        public uint Result { get; set; }
        public string ErrorMessage { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public IronMace_Login_Res Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(IronMace_Login_Res? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(IronMace_Login_Res message)
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

        // Implement IMessage<IronMace_Login_Res>
    }

    public enum IronMace_Login_Result
    {
        NONE = 0,
        SUCCESS = 1,
        FAIL_NOT_FOUND_ACCOUNT = 100,
        FAIL_WRONG_PASSWORD = 101
    }

    public sealed partial class IronMace_Token : IMessage<IronMace_Token>
    {
        public string LoginId { get; set; }
        public string Password { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public IronMace_Token Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(IronMace_Token? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(IronMace_Token message)
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

        // Implement IMessage<IronMace_Token>
    }

    public sealed partial class IronMace_Token_Res : IMessage<IronMace_Token_Res>
    {
        public string Token { get; set; }

        public MessageDescriptor Descriptor => throw new NotImplementedException();

        public int CalculateSize()
        {
            throw new NotImplementedException();
        }

        public IronMace_Token_Res Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(IronMace_Token_Res? other)
        {
            throw new NotImplementedException();
        }

        public void MergeFrom(IronMace_Token_Res message)
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

        // Implement IMessage<IronMace_Token_Res>
    }
}
