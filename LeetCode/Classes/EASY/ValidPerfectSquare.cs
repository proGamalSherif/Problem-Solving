using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ValidPerfectSquare
    {
        public static void Run()
        {
            int num = 16;
            bool isPerfect = IsPerfectSquare(num);
            Console.WriteLine(isPerfect);
            num = 14;
            isPerfect= IsPerfectSquare(num);
            Console.WriteLine(isPerfect);
        }
        public static bool IsPerfectSquare(int num)
        {
            int sNumber = (int)Math.Sqrt(num);
            if ((sNumber * sNumber) == num)
            {
                return true;
            }
            return false;
        }
    }
}
