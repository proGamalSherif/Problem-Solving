using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ReverseStrings
    {
        public static void Run()
        {
            char[] s = new char[]{'H', 'a', 'n', 'n', 'a', 'h'};
            Console.WriteLine($"Before Reverse {new string(s)}");
            reverse_String(s);
            Console.WriteLine($"AFter Reverse {new string(s)}");
        }
        public static void reverse_String(char[] s)
        {
            int leftIndex = 0;
            int rightIndex = s.Length - 1;
            while(leftIndex < rightIndex)
            {
                char temp = s[leftIndex];
                s[leftIndex] = s[rightIndex];
                s[rightIndex] = temp;
                leftIndex++;
                rightIndex--;
            }
        }
    }
}
