using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class FizzBuzz
    {
        public static void Run()
        {
            Console.Write("Please Provide a Number : ");
            int n = int.Parse(Console.ReadLine());
            IList<string> result = Fizz_Buzz(n);
            Console.WriteLine($"[{string.Join(",", result)}]");
        }
        public static IList<string> Fizz_Buzz(int n)
        {
            IList<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                bool isAdded = false;
                if (i % 5 == 0 & i % 3 == 0)
                {
                    result.Add("FizzBuzz");
                    isAdded = true;
                    continue;
                }
                if (i % 5 == 0 || i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        result.Add("Buzz");
                        isAdded = true;
                        continue;
                    }
                    else
                    {
                        result.Add("Fizz");
                        isAdded = true;
                        continue;
                    }
                }
                if (!isAdded)
                {
                    result.Add(i.ToString());
                    continue;
                }
            }
            return result;
        }
    }
}
