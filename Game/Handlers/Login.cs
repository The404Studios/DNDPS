using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Google.Protobuf;
using DarkAndDarker.Cryptography.Sequence.Account;
using DarkAndDarker.Cryptography.Sequence.Common;

namespace SVERA.Services
{
    public static class AccountService
    {
        private static readonly Random Random = new Random();

        public static SS2C_ACCOUNT_LOGIN_RES ProcessLogin(Context ctx, byte[] msg)
        {
            var req = SC2S_ACCOUNT_LOGIN_REQ.Parser.ParseFrom(msg);

            // Initialize response with default values
            var res = new SS2C_ACCOUNT_LOGIN_RES
            {
                ServerLocation = 1
            };

            // Return FAIL_SHORT_ID_OR_PASSWORD on too short username/password
            if (req.LoginId.Length <= 2 || req.Password.Length <= 2)
            {
                res.Result = SS2C_ACCOUNT_LOGIN_RES.Types.Result.FailShortIdOrPassword;
                return res;
            }

            // Return FAIL_OVERFLOW_ID_OR_PASSWORD on too long username
            if (req.LoginId.Length > 20)
            {
                res.Result = SS2C_ACCOUNT_LOGIN_RES.Types.Result.FailOverflowIdOrPassword;
                return res;
            }

            var account = DatabaseContext.Instance.Accounts
                .FirstOrDefault(a => a.Username.Equals(req.LoginId, StringComparison.OrdinalIgnoreCase));

            if (account == null)
            {
                // Create a new account
                account = new Account
                {
                    Username = req.LoginId,
                    Password = HashPassword(req.Password),
                    SecretToken = GenerateSecretToken()
                };
                DatabaseContext.Instance.Accounts.Add(account);
                DatabaseContext.Instance.SaveChanges();

                res.SecretToken = account.SecretToken;
            }

            // Check if an hwId is associated with the account_id, if not add to db
            foreach (var hwid in req.HwIds)
            {
                if (!DatabaseContext.Instance.HwIds.Any(h => h.Hwid == hwid && h.AccountId == account.Id))
                {
                    var newHwid = new Hwid
                    {
                        AccountId = account.Id,
                        Hwid = hwid,
                        SeenAt = DateTime.UtcNow
                    };
                    DatabaseContext.Instance.HwIds.Add(newHwid);
                    DatabaseContext.Instance.SaveChanges();
                }
            }

            // Return FAIL_PASSWORD on invalid password
            if (!VerifyPassword(account.Password, req.Password))
            {
                res.Result = SS2C_ACCOUNT_LOGIN_RES.Types.Result.FailPassword;
                return res;
            }

            // Returns the respective SS2C_ACCOUNT_LOGIN_RES ban enum
            if (account.BanType != null)
            {
                res.Result = account.BanType.Value;
                return res;
            }

            res.AccountId = account.Id.ToString();
            var info = new SLOGIN_ACCOUNT_INFO
            {
                AccountID = account.Id.ToString()
            };
            res.AccountInfo = info;

            KickConcurrentUser(account);

            SessionManager.Sessions[ctx.Transport].Account = account;

            ServicePolicyNotification(ctx);

            return res;
        }

        private static string HashPassword(string password)
        {
            using (var hasher = new Rfc2898DeriveBytes(password, new byte[16], 10000))
            {
                return Convert.ToBase64String(hasher.GetBytes(20));
            }
        }

        private static bool VerifyPassword(string hashedPassword, string password)
        {
            var hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }

        private static string GenerateSecretToken()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Range(0, 21).Select(_ => chars[Random.Next(chars.Length)]).ToArray());
        }

        private static void ServicePolicyNotification(Context ctx)
        {
            // Policy Type '7' refers to High-Roller
            var policy = new FSERVICE_POLICY
            {
                PolicyType = 7,
                PolicyValue = 100
            };

            var notify = new SS2C_SERVICE_POLICY_NOT
            {
                PolicyList = { policy }
            };

            ctx.Reply(notify);
        }

        private static void KickConcurrentUser(Account newlyConnectedAccount)
        {
            foreach (var (transport, user) in SessionManager.Sessions)
            {
                if (user.Account == newlyConnectedAccount)
                {
                    transport.Disconnect(); // Adjust based on actual method to disconnect a user
                    break;
                }
            }
        }
    }
}
