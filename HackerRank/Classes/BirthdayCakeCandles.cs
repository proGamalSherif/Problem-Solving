using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class BirthdayCakeCandles
    {
        public static void Run()
        {
            List<int> candles = new List<int> { 3, 2, 1, 3 };
            int result = birthdayCakeCandles(candles);  
            Console.WriteLine(result);
        }
        public static int birthdayCakeCandles(List<int> candles)
        {

            int maxNumber = candles.Max();
            int mCount = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i] == maxNumber)
                {
                    mCount++;
                }
            }


            return mCount;
        }
    }
}
