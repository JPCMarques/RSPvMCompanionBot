using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core
{
    public class Charm : Item
    {
        public Charm(string name, string examine, string internalID) : base(name, examine, internalID, 0)
        {
        }
    }
}
