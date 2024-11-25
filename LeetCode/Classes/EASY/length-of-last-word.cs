using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class length_of_last_word
    {
        public static void Run()
        {
            string s = "luffy is still joyboy";
            int count = LengthOfLastWord(s);
            Console.WriteLine(count);
        }
        public static int LengthOfLastWord(string s)
        {
            s=s.Trim();
            if(s.Length == 0)
                return 0;
            else
            {
                string[] sStr = s.Split(" ");
                string lastWord = sStr[sStr.Length - 1];
                lastWord=lastWord.Trim();
                return lastWord.Length;
            }

        }
    }
}
