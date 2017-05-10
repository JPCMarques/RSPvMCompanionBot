using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core.Slayer
{
    public class SlayerMaster
    {
        public string Name;
        public int SlayerLevel;
        public int TotalWeight;
        public Dictionary<SlayerMasterAssignment, int> Assignments;

        public SlayerMaster(string name, int slayerLevel, int totalWeight)
        {
            Name = name;
            SlayerLevel = slayerLevel;
            TotalWeight = totalWeight;
            Assignments = new Dictionary<SlayerMasterAssignment, int>();
        }
    }
}
