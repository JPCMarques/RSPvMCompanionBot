using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Utility
{
    public abstract class CommandRecognizer
    {
        public static Dictionary<Regex, ICollection<string>> Recognize(ref string input, ICollection<Regex> recognizers)
        {
            Dictionary<Regex, ICollection<string>> matchedRegexes = new Dictionary<Regex, ICollection<string>>();
            foreach (Regex regex in recognizers)
            {
                MatchCollection regexMatches = regex.Matches(input);
                if (regexMatches.Count != 0)
                {
                    List<string> recognizedArgs = new List<string>();
                    for (int i = 0; i < regexMatches.Count; i++)
                    {
                        string matchedString = regexMatches[i].ToString();
                        recognizedArgs.Add(matchedString);
                        input = input.Remove(input.IndexOf(matchedString), matchedString.Length);
                    }
                    matchedRegexes.Add(regex, recognizedArgs);
                }
            }

            return matchedRegexes;
        }

    }
}
