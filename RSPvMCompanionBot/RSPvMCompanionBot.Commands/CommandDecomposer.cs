using RSPvMCompanionBot.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Utility
{
    public class CommandDecomposer
    {

        /*
        public static ArgumentDataMatches ParseCommandInput(ArgumentData argumentData, out string input, bool optArgsFirst)
        {
            ArgumentDataMatches matches = new ArgumentDataMatches();
            Dictionary<Regex, ICollection<string>> optArgsMatched, argsMatched;
            if (optArgsFirst)
            {
                optArgsMatched = CommandRecognizer.Recognize(out input, argumentData.OptArgs.Values);
                argsMatched = CommandRecognizer.Recognize(out input, argumentData.Args.Values);
            }
            else
            {
                argsMatched = CommandRecognizer.Recognize(out input, argumentData.Args.Values);
                optArgsMatched = CommandRecognizer.Recognize(out input, argumentData.OptArgs.Values);
            }
        }*/

        public static string RemoveMultipleSpaces(string input)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            return regex.Replace(input, " ");
        }
       
    }
}
