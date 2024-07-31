using DarkAndDarker.Cryptography.Sequence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVERA.Services
{
    public static class LocationService
    {
        public static SS2C_META_LOCATION_RES ProcessLocation(Context ctx, byte[] msg)
        {
            var req = SC2S_META_LOCATION_REQ.Parser.ParseFrom(msg);

            // Update the location
            var session = SessionManager.Sessions[ctx.Transport];
            session.State.Location = req.Location;

            // Send the party the new location the user is in
            PartyHandler.SendPartyLocationNotification(session.Party, session);

            // Respond to the location request
            return new SS2C_META_LOCATION_RES
            {
                Location = req.Location
            };
        }
    }
}