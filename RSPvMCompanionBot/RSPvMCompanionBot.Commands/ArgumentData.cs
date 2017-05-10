using RSPvMCompanionBot.Utility;
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
        public Dictionary<string, ICollection<string>> ArgData = new Dictionary<string, ICollection<string>>();
        public Dictionary<string, ICollection<string>> OptArgData = new Dictionary<string, ICollection<string>>();

        public ArgumentData(ArgumentSpecification argSpec, ArgumentDataMatches argDataMatches)
        {
            ArgData = DictionaryBridger<string, Regex, ICollection<string>>.Bridge(argSpec.Args, argDataMatches.ArgsMatches);
            OptArgData = DictionaryBridger<string, Regex, ICollection<string>>.Bridge(argSpec.OptArgs, argDataMatches.OptArgsMatches);
        }
    }
}
