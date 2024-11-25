using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class VeryBigSum
    {
        public static void Run()
        {

            List<long> ar = new List<long>{ 1000000001 ,1000000002, 1000000003 ,1000000004 ,1000000005 };
            long result = aVeryBigSum(ar);
            Console.WriteLine(result);
        }
        static long aVeryBigSum(List<long> ar)
        {

            long result = 0;
            for(int i = 0; i < ar.Count; i++)
            {
                result+= ar[i];
            }
            return result;

        }
    }
}
