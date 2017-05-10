using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core
{
    public class Monster
    {
        public string Name;
        public string Examine;
        public string WikiUrl;
        public string ThumbUrl;
        public string InternalID;
        public int HP;
        public float CombatExp;
        public ICollection<DropTable> DropTables;

        public Monster(string name, string examine, string wikiUrl, string thumbUrl, string internalID, int hp, float combatExp)
        {
            Name = name;
            Examine = examine;
            WikiUrl = wikiUrl;
            ThumbUrl = thumbUrl;
            InternalID = internalID;
            HP = hp;
            CombatExp = combatExp;
            DropTables = new List<DropTable>();
        }
    }
}
