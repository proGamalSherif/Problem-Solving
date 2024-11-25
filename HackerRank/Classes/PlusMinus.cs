using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class PlusMinus
    {
        public static void Run()
        {

          
            List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };
            plusMinus(arr);

        }

        public static void plusMinus(List<int> arr)
        {

            int totalCount = arr.Count;
            int tPositive = 0;
            int tNegative = 0;
            int tZeros = 0;

            for(int i =0;i<totalCount;i++)
            {
                if (arr[i] == 0)
                {
                    tZeros++;
                }else if (arr[i] > 0)
                {
                    tPositive++;
                }else if(arr[i] < 0)
                {
                    tNegative++;
                }
            }



            Console.WriteLine((double)tPositive / totalCount);
            Console.WriteLine((double)tNegative / totalCount);
            Console.WriteLine((double)tZeros / totalCount);



        }

    }
}
