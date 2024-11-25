using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class add_binary
    {
        public static void Run()
        {

            string a = "1010", b = "1011";
            string result = AddBinary(a, b);
            Console.WriteLine(result);

        }
        public static string AddBinary(string a, string b)
        {

            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            StringBuilder result = new StringBuilder();
            while (i >= 0 || j >= 0 || carry != 0)
            {
                int sum = carry;

                if (i >= 0)
                {
                    sum += a[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                carry = sum / 2;
                result.Insert(0, sum % 2);
            }

            return result.ToString();
        }
    }
}
