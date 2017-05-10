using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core
{
    public class Item
    {
        public string Name;
        public string Examine;
        public string InternalID;
        public int Value;

        public Item(string name, string examine, string internalID, int value)
        {
            Name = name;
            Examine = examine;
            InternalID = internalID;
            Value = value;
        }
    }
}
