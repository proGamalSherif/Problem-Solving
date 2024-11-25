using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class SimpleArraySum
    {
        public static void Run()
        {
            //int[] ar = { 1, 2, 3 };
            List<int> ar = new List<int> { 1, 2, 3 };
            int result = simpleArraySum(ar);
            Console.WriteLine(result);
        }
        public static int simpleArraySum(List<int> ar)
        {
            double totalSum = 0;
            for(int i =0;i<ar.Count;i++)
            {
                totalSum+= ar[i];
            }
            return (int)totalSum;

        }

    }
}
