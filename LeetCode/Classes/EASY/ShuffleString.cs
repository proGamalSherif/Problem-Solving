using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.JavaScript;
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
            Console.WriteLine(s);

        }
        public static string RestoreString(string s, int[] indices)
        {
            char[] result = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                result[indices[i]] = s[i];
            }
            return new string(result);
        }
    }
}
