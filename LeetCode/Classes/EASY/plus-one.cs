using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class plus_one
    {
        public static void Run()
        {
            int[] digits = [9, 8, 7, 6, 5, 3, 2, 1, 0];
            int[] result = PlusOne(digits);
            Console.Write($"{string.Join(",", result)}");
        }
        public static int[] PlusOne(int[] digits)
        {
            string tempDigits = "";
            for (int i = 0; i < digits.Length; i++)
            {
                tempDigits = tempDigits + digits[i].ToString();
            }
            BigInteger tempIntDigits = BigInteger.Parse(tempDigits);
            tempIntDigits += 1;
            int[] digitArray = tempIntDigits.ToString()
                         .Select(ch => int.Parse(ch.ToString()))
                         .ToArray();

            return digitArray;


        }
    }
}
