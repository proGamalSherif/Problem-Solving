using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class find_the_index_of_the_first_occurrence_in_a_string
    {
        public static void Run()
        {
            string haystack = "leetcode", needle = "leeto";
            int result = StrStr(haystack, needle);
            Console.WriteLine(result);

        }
        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            else
            {
                return -1;
            }
        }
    }
}
