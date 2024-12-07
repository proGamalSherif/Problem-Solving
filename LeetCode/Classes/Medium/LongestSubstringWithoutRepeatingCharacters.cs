using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.Medium
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        public static void Run()
        {
            string s = "abcabcbb";
            int result = LengthOfLongestSubstring(s);
            Console.WriteLine(result);
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            int start = 0;  

            for (int end = 0; end < s.Length; end++)
            {
                for (int i = start; i < end; i++)
                {
                    if (s[end] == s[i])
                    {
                        start = i + 1;
                        break;
                    }
                }
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }

    }
}
