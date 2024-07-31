using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace DndServer.Objects
{
    public class User
    {
        // Define the User class here
    }

    public class Party
    {
        private static int partyId = 0;
        public int Id { get; private set; }
        public List<User> Players { get; private set; }
        public User Leader { get; private set; }

        public Party(User player1)
        {
            Id = ++partyId;
            Players = new List<User> { player1 };
            Leader = player1;
        }

        public void AddMember(User user)
        {
            if (Players.Count >= 3)
            {
                throw new InvalidOperationException("No room in that party for any more players.");
            }
            Players.Add(user);
        }

        public void RemoveMember(User user)
        {
            if (!Players.Contains(user))
            {
                throw new InvalidOperationException("User is not in that party.");
            }
            Players.Remove(user);
        }
    }
}
