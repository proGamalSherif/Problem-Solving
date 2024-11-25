using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class PalindromeNumbers
    {
        public static void Run()
        {
            bool result = IsPalindrome(121);
            if (result)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int originalNumber = x;
            int reveresedNumber = 0;
            while (x > 0)
            {
                int digit = x % 10;
                reveresedNumber = reveresedNumber * 10 + digit;
                x /= 10;
            }
            return originalNumber == reveresedNumber;

        }


        //public static bool IsPalindrome(int x)
        //{
        //    if (x < 0) // Negative numbers are not palindromes
        //    {
        //        return false;
        //    }

        //    int originalNumber = x;
        //    int reversedNumber = 0;

        //    // Reverse the number
        //    while (x > 0)
        //    {
        //        int digit = x % 10;  // Get the last digit
        //        reversedNumber = reversedNumber * 10 + digit; // Build the reversed number
        //        x /= 10; // Remove the last digit from x
        //    }

        //    // Compare the original number with the reversed number
        //    return originalNumber == reversedNumber;
        //}

    }
}
