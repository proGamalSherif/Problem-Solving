using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class SolveMeFirst
    {
        public static void Run()
        {
            int x = 7, y = 3;
            int result = getSum(x, y);
            Console.WriteLine(result);
        }
        static int getSum(int x, int y)
        {
            return x + y;
        }
    }
}
