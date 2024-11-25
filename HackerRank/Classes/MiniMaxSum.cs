using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class MiniMaxSum
    {
        public static void Run()
        {
            List<int> list = new List<int> {1,3,5,7,9};
            miniMaxSum(list);
        }
        public static void miniMaxSum(List<int> arr)
        { 
            long totalSum = arr.Sum(x => (long)x);
            long minSum = totalSum - arr.Max();
            long maxSum = totalSum - arr.Min();
            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}
