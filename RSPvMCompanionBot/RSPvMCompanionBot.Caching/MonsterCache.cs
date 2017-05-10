using RSPvMCompanionBot.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Caching
{
    public class MonsterCache
    {
        private static Dictionary<string, Monster> monsterCache;

        public static void AddMonster(Monster monster, bool force)
        {
            if (monsterCache == null) monsterCache = new Dictionary<string, Monster>();
            if (force || !ContainsMonster(monster.InternalID))
            {
                ICollection<DropTable> dropTables = monster.DropTables;

                foreach (DropTable dropTable in dropTables)
                {
                    DropTableCache.AddDropTable(dropTable, force);
                }

                monsterCache[monster.InternalID] = monster;
            }
        }

        public static Monster GetMonster(string internalID)
        {
            if (monsterCache == null) monsterCache = new Dictionary<string, Monster>();
            return monsterCache[internalID];
        }

        public static bool ContainsMonster(string internalID)
        {
            if (monsterCache == null) monsterCache = new Dictionary<string, Monster>();
            return monsterCache.ContainsKey(internalID);
        }
    }
}
