using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class RomanNumbers
    {
        public static void Run()
        {
            string s = "LVIII";
            int result = RomanToInt(s);
            if (result == 0)
            {
                Console.WriteLine("Failed To Retrieve this number");
            }
            else
            {
                Console.WriteLine($"Success to get the number is {result}");
            }
        }
        public static bool ContainsOnlyRomanNumerals(string input)
        {
            string validChars = "IVXLCDM";
            return input.All(c => validChars.Contains(c));
        }
        public static int RomanToInt(string s)
        {

            if (s == null)
            {
                return 0;
            }
            if (1 <= s.Length || s.Length <= 15)
            {
                bool isAvailableString = ContainsOnlyRomanNumerals(s);
                if (isAvailableString)
                {
                    Dictionary<char, int> romanNumerals = new Dictionary<char, int>()
                    {
                        {'I', 1},
                        {'V', 5},
                        {'X', 10},
                        {'L', 50},
                        {'C', 100},
                        {'D', 500},
                        {'M', 1000}
                    };
                    int total = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (i + 1 < s.Length && romanNumerals[s[i]] < romanNumerals[s[i + 1]])
                        {
                            total -= romanNumerals[s[i]];
                        }
                        else
                        {
                            total += romanNumerals[s[i]];
                        }
                    }
                    return total;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
