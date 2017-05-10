using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core.Slayer
{
    public class SlayerMonster : Monster
    {
        public float SlayerExp;
        public int SlayerLevel;
        public ICollection<SlayerMaster> AssignedBy;
        public Archetype Archetype;

        public SlayerMonster(string name, string examine, string wikiUrl, string thumbUrl, string internalId, int hp, float combatExp, float slayerExp, int slayerLevel, Archetype archetype)
            : base(name, examine, wikiUrl, thumbUrl, internalId, hp, combatExp)
        {
            SlayerExp = slayerExp;
            SlayerLevel = slayerLevel;
            Archetype = archetype;
            AssignedBy = new List<SlayerMaster>();
        }
    }
}
