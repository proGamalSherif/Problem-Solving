using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ValidPalindrome
    {
        public static void Run()
        {
            string s = "A man, a plan, a canal: Panama";
            bool result = IsPalindrome(s);
        }
        public static bool IsPalindrome(string s)
        {
            s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            int left = 0, right = s.Length - 1; 
            while(left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;

        }
    }
}
