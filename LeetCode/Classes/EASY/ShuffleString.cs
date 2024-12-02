using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ShuffleString
    {
        public static void Run()
        {

            string s = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
            Console.WriteLine($"[{string.Join(",", indices)}]");

        }
        public static string RestoreString(string s, int[] indices)
        {
            char[] shuffled = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                shuffled[indices[i]] = s[i];
            }
            return new string(shuffled);
        }
    }
}
