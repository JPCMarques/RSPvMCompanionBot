using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Commands
{
    public class ArgumentDataMatches
    {
        public Dictionary<Regex, ICollection<string>> ArgsMatches;
        public Dictionary<Regex, ICollection<string>> OptArgsMatches;
    }
}
