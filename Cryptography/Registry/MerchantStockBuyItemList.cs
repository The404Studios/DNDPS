using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generated code from protoc. Do not edit.

public sealed partial class MerchantStockBuyItemListRes : pb::IMessage<MerchantStockBuyItemListRes>
{
    public const int ResultFieldNumber = 1;
    private int result_;
    public const int LoopMessageFlagFieldNumber = 2;
    private int loopMessageFlag_;
    public const int StockListFieldNumber = 3;
    private static readonly pb::FieldCodec<SMERCHANT_STOCK_BUY_ITEM_INFO> _repeated_stockList_codec =
        pb::FieldCodec.ForMessage(26, SMERCHANT_STOCK_BUY_ITEM_INFO.Parser);
    private readonly pbc::RepeatedField<SMERCHANT_STOCK_BUY_ITEM_INFO> stockList_ = new pbc::RepeatedField<SMERCHANT_STOCK_BUY_ITEM_INFO>();

    public int Result
    {
        get { return result_; }
        set { result_ = value; }
    }

    public int LoopMessageFlag
    {
        get { return loopMessageFlag_; }
        set { loopMessageFlag_ = value; }
    }

    public pbc::RepeatedField<SMERCHANT_STOCK_BUY_ITEM_INFO> StockList
    {
        get { return stockList_; }
    }

    // Methods and other implementation details...
}
