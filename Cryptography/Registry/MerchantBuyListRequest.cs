using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generated code from protoc. Do not edit.

public sealed partial class MerchantStockBuyItemListReq : pb::IMessage<MerchantStockBuyItemListReq>
{
    public const int MerchantIdFieldNumber = 1;
    private string merchantId_ = "";

    public string MerchantId
    {
        get { return merchantId_; }
        set { merchantId_ = value; }
    }

    // Methods and other implementation details...
}
