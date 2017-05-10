using RSPvMCompanionBot.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RSPvMCompanionBot.Caching
{
    public class ItemCache
    {
        private static Dictionary<string, Item> itemCache;

        public static void AddItem(Item item, bool force)
        {
            if (itemCache == null) itemCache = new Dictionary<string, Item>();
            if (force || !ContainsItem(item.InternalID)) itemCache[item.InternalID] = item;
        }
        
        public static Item GetItem(string internalID)
        {
            if (itemCache == null) itemCache = new Dictionary<string, Item>();
            return itemCache[internalID];
        }

        public static bool ContainsItem(string internalID)
        {
            if (itemCache == null) itemCache = new Dictionary<string, Item>();
            return itemCache.ContainsKey(internalID);
        }
    }
}
