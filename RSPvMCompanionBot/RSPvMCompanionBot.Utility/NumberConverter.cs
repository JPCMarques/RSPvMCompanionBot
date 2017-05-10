using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RSPvMCompanionBot.Utility
{
    public abstract class NumberConverter
    {
        private static Dictionary<Regex, int> magnitudes = new Dictionary<Regex, int>();
        private static bool isInitialized = false;
        private static float B/*iiiiiiiiiiilllllll*/ = 1000000000f, M = 1000000f, K = 1000f;

        private static void Init()
        {
            if (!isInitialized)
            {
                RegexOptions options = RegexOptions.None;
                Regex kRegex = new Regex("[kK]", options);
                Regex mRegex = new Regex("[mM]", options);
                Regex bRegex = new Regex("[bB]", options);

                magnitudes[kRegex] = 1000;
                magnitudes[mRegex] = 1000000;
                magnitudes[bRegex] = 1000000000;
                isInitialized = true;
            }
        }

        public static float ConvertFromRSNumber(string number)
        {
            Init();

            foreach (Regex regex in magnitudes.Keys)
            {
                if (regex.IsMatch(number))
                {
                    string tmp = regex.Replace(number, "");
                    float actualNumber = float.Parse(tmp);
                    return actualNumber * magnitudes[regex];
                }
            }

            return float.Parse(number);
        }

        public static string ConvertToRSNumber(float number)
        {
            Init();
            float temp = number;
            string terminator = "";

            if (number > B)
            {
                temp = number / B;
                terminator = "b";
            }
            else if (number > M)
            {
                terminator = "m";
                temp = number / M;
            }
            else if (number > K)
            {
                terminator = "k";
                temp = number / K;
            }
            return temp + terminator;
        }
    }
}
