using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class Climbing_stairs
    {
        public static void Run()
        {
            int n = 2;
            int result = ClimbStairs(n);
            Console.WriteLine(result);

        }
        public static int ClimbStairs(int n)
        {
            if(n == 0) return 0;    
            else if(n == 1) return 1;
            else
            {
                int firstStep = 1;
                int secondStep = 2;
                for(int i = 3;i<= n;i++)
                {
                    int currentStep = firstStep + secondStep;
                    firstStep = secondStep;
                    secondStep=currentStep;
                }
                return secondStep;
            }
        }
    }
}
