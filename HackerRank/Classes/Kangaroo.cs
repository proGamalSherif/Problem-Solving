using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class Kangaroo
    {

        public static void Run()
        {
            int x1 = 0, v1 = 2, x2 = 5, v2 = 3;
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 == v2)
            {
                return x1 == x2 ? "YES" : "NO";
            }

            if ((x2 > x1 && v2 >= v1) || (x1 > x2 && v1 >= v2))
            {
                return "NO";
            }

            int relativePosition = Math.Abs(x2 - x1);
            int relativeSpeed = Math.Abs(v1 - v2);

            if (relativePosition % relativeSpeed == 0)
            {
                return "YES";
            }

            return "NO";
        }

    }
}
