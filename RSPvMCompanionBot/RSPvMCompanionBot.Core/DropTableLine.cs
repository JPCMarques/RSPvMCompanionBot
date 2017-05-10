using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core
{
    public class DropTableLine
    {
        public Item Item;
        public int LowerBound;
        public int UpperBound;
        public float DropChance;

        public DropTableLine(Item item, int lowerBound, int upperBound, float dropChance)
        {
            Item = item;
            LowerBound = lowerBound;
            UpperBound = upperBound;
            DropChance = dropChance;
        }
    }
}
