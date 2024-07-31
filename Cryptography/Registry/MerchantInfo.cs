// Generated code from protoc. Do not edit.

public sealed partial class MerchantInfo : pb::IMessage<MerchantInfo>
{
    // Fields
    public const int MerchantIdFieldNumber = 1;
    private string merchantId_ = "";
    public const int FactionFieldNumber = 2;
    private int faction_;
    public const int RemainTimeFieldNumber = 3;
    private int remainTime_;
    public const int IsUnidentifiedFieldNumber = 4;
    private int isUnidentified_;

    // Properties
    public string MerchantId
    {
        get { return merchantId_; }
        set { merchantId_ = value; }
    }

    public int Faction
    {
        get { return faction_; }
        set { faction_ = value; }
    }

    public int RemainTime
    {
        get { return remainTime_; }
        set { remainTime_ = value; }
    }

    public int IsUnidentified
    {
        get { return isUnidentified_; }
        set { isUnidentified_ = value; }
    }

    // Methods and other implementation details...
}
