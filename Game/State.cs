using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndServer.Protos.Defines;

namespace DndServer.Objects
{
    public class State
    {
        public bool IsReady { get; set; }
        public Define_Common.MetaLocation Location { get; set; }

        public State()
        {
            IsReady = false;
            Location = Define_Common.MetaLocation.PLAY;
        }
    }
}

