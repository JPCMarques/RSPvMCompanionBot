using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Core
{
    public class DropTable
    {
        public ICollection<DropTableLine> Drops;
        public float AvgValue;
        public string InternalID;

        public DropTable(string internalID)
        {
            Drops = new List<DropTableLine>();
            AvgValue = 0;
            InternalID = internalID;
        }
    }
}
