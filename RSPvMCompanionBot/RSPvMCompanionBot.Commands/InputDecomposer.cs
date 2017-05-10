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
        public static ArgumentDataMatches ParseCommandInput(ArgumentSpecification argumentSpec, ref string input, bool optArgsFirst = true)
        {
            ArgumentDataMatches matches = new ArgumentDataMatches();
            input = RemoveMultipleSpaces(input);

            if (optArgsFirst)
            {
                matches.OptArgsMatches = CommandRecognizer.Recognize(ref input, argumentSpec.OptArgs.Values);
                matches.ArgsMatches = CommandRecognizer.Recognize(ref input, argumentSpec.Args.Values);
            }
            else
            {
                matches.ArgsMatches = CommandRecognizer.Recognize(ref input, argumentSpec.Args.Values);
                matches.OptArgsMatches = CommandRecognizer.Recognize(ref input, argumentSpec.OptArgs.Values);
            }

            return matches;
        }

        public static void PrepareCommand(Command<object> command, ref string input, bool optArgsFirst = true)
        {
            command.ArgData = new ArgumentData(command.ArgSpec, ParseCommandInput(command.ArgSpec, ref input, optArgsFirst));
        }

        public static string RemoveMultipleSpaces(string input)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            return regex.Replace(input, " ");
        }
       
    }
}
