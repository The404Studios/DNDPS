using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkAndDarker.Game.Enum
{
    internal class account
    {
    }
}

public enum BanType
{
    FailLoginBanUser = 12,
    FailLoginBanUserCheater = 13,
    FailLoginBanUserInappropriateName = 14,
    FailLoginBanUserEtc = 15,
    FailLoginBanHardware = 16
}

public class BanManager
{
    public void HandleBan(BanType banType)
    {
        switch (banType)
        {
            case BanType.FailLoginBanUser:
                // Handle fail login ban user
                break;
            case BanType.FailLoginBanUserCheater:
                // Handle fail login ban user cheater
                break;
            case BanType.FailLoginBanUserInappropriateName:
                // Handle fail login ban user inappropriate name
                break;
            case BanType.FailLoginBanUserEtc:
                // Handle fail login ban user etc
                break;
            case BanType.FailLoginBanHardware:
                // Handle fail login ban hardware
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

