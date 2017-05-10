using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core.Slayer
{
    public class SlayerMasterAssignment
    {
        public Archetype Archetype;
        public int LowerBound;
        public int UpperBound;

        public SlayerMasterAssignment(Archetype archetype, int lowerBound, int upperBound)
        {
            Archetype = archetype;
            LowerBound = lowerBound;
            UpperBound = upperBound;
        }
    }
}
