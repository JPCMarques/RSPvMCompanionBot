using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Utility
{
    public class DictionaryBridger<Key, KeyAndValue, Value>
    {
        public static Dictionary<Key, Value> Bridge(Dictionary<Key, KeyAndValue> a, Dictionary<KeyAndValue, Value> b)
        {
            Dictionary<Key, Value> bridgedDict = new Dictionary<Key, Value>();
            foreach (Key key in a.Keys)
            {
                if (b.ContainsKey(a[key]))
                {
                    bridgedDict.Add(key, b[a[key]]);
                }
            }

            return bridgedDict;
        }
    }
}
