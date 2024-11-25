using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class LongestPrefix
    {
        public static void Run()
        {
            string[] strs = ["dog", "racecar", "car"];
            string result = LongestCommonPrefix(strs);
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no common prefix among the input strings.");
            }
        }
        public static string LongestCommonPrefix(string[] strs)
        {

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                string currentValue = strs[i];
                while (currentValue.IndexOf(prefix) != 0)
                {
                    if (prefix.Length == 0) return "";
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }

            }

            return prefix;

        }
    }
}
