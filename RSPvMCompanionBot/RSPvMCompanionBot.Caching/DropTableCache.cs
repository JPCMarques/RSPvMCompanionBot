using RSPvMCompanionBot.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Caching
{
    public class DropTableCache
    {
        private static Dictionary<string, DropTable> dropTableCache;

        public static void AddDropTable(DropTable dropTable, bool force)
        {
            if (dropTableCache == null) dropTableCache = new Dictionary<string, DropTable>();
            if(force || !ContainsDropTable(dropTable.InternalID))
            {
                ICollection<DropTableLine> drops = dropTable.Drops;

                foreach (DropTableLine drop in drops)
                {
                    ItemCache.AddItem(drop.Item, force);
                }

                dropTableCache[dropTable.InternalID] = dropTable;
            }
        }

        public static DropTable GetDropTable(string internalID)
        {
            if (dropTableCache == null) dropTableCache = new Dictionary<string, DropTable>();
            return dropTableCache[internalID];
        }

        public static bool ContainsDropTable(string internalID)
        {
            if (dropTableCache == null) dropTableCache = new Dictionary<string, DropTable>();
            return dropTableCache.ContainsKey(internalID);
        }
    }
}
