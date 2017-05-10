using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core.Slayer
{
    public class Archetype
    {
        public string Name;
        public ICollection<SlayerMonster> Monsters;

        public Archetype (string name)
        {
            Name = name;
            Monsters = new List<SlayerMonster>();
        }
    }
}
