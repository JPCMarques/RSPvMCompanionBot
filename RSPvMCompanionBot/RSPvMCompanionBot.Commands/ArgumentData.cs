using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Commands
{
    public class ArgumentData
    {
        public Dictionary<string, Regex> Args;
        public Dictionary<string, Regex> OptArgs;
        public int MinArgs, MaxArgs;
    }
}
