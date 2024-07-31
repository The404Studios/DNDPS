using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;

namespace SVERA.Services
{
    public static class TradeService
    {
        public static SS2C_TRADE_MEMBERSHIP_REQUIREMENT_RES GetTradeRequirements(SessionContext ctx, byte[] msg)
        {
            // Create and populate the response
            var res = new SS2C_TRADE_MEMBERSHIP_REQUIREMENT_RES
            {
                Requirements =
                {
                    new STRADE_MEMBERSHIP_REQUIREMENT
                    {
                        MemberShipType = 1, // TODO: Replace with actual value
                        MemberShipValue = 1 // TODO: Replace with actual value
                    }
                }
            };

            return res;
        }
    }
}