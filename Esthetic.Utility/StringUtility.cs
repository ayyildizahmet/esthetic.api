using Esthetic.Core.Contracts.Utilities;
using System;
using System.Text.RegularExpressions;

namespace Esthetic.Utility
{
    public class StringUtility : IStringUtility
    {
        private static Regex WordRegex = new Regex(@"\p{Lu}\p{Ll}+|\p{Lu}+(?!\p{Ll})|\p{Ll}+|\d+");

        public string ToPascalCase(string input)
        {
            return WordRegex.Replace(input, EvaluatePascal);
        }

        public string ToCamelCase(string input)
        {
            string pascal = ToPascalCase(input);
            return WordRegex.Replace(pascal, EvaluateFirstCamel, 1);
        }

        private static string EvaluateFirstCamel(Match match)
        {
            return match.Value.ToLower();
        }

        private static string EvaluatePascal(Match match)
        {
            string value = match.Value;
            int valueLength = value.Length;

            if (valueLength == 1)
                return value.ToUpper();
            else
            {
                if (valueLength <= 2 && IsWordUpper(value))
                    return value;
                else
                    return value.Substring(0, 1).ToUpper() + value.Substring(1, valueLength - 1).ToLower();
            }
        }

        private static bool IsWordUpper(string word)
        {
            bool result = true;

            foreach (char c in word)
            {
                if (Char.IsLower(c))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

       
    }
}
