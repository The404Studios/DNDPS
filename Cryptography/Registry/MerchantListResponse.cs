using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed partial class MerchantListRes : pb::IMessage<MerchantListRes>
{
    public const int MerchantListFieldNumber = 1;
    private static readonly pb::FieldCodec<SMERCHANT_INFO> _repeated_merchantList_codec = pb::FieldCodec.ForMessage(10, SMERCHANT_INFO.Parser);
    private readonly pbc::RepeatedField<SMERCHANT_INFO> merchantList_ = new pbc::RepeatedField<SMERCHANT_INFO>();

    public pbc::RepeatedField<SMERCHANT_INFO> MerchantList
    {
        get { return merchantList_; }
    }

    // Methods and other implementation details...
}
