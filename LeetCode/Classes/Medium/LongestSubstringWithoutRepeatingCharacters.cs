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
            Console.WriteLine(s);
        }
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
            int maxLength = 0;
            int start = 0; 

            for (int end = 0; end < s.Length; end++)
            {
                char currentChar = s[end];
                if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= start)
                {
                    start = charIndexMap[currentChar] + 1; 
                }
                charIndexMap[currentChar] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            return maxLength;
        }
    }
}
