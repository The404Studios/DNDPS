using DarkAndDarker.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndServer.Objects
{
    public class User
    {
        public object Account { get; set; }
        public object Character { get; set; }
        public object Party { get; set; }
        public State State { get; set; }

        public User()
        {
            Account = null;
            Character = null;
            Party = null;
            State = null;
        }
    }
}
