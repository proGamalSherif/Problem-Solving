using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class NumbersSmallerThanCurrent
    {
        public static void Run()
        {
            int[] nums = [6, 5, 4, 8];
            int[] result = SmallerNumbersThanCurrent(nums);
            Console.WriteLine($"[{string.Join(",", result)}]");
        }
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] newResult = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int cNumber = nums[i];
                int cCount = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (cNumber > nums[j])
                    {
                        cCount++;
                    }
                }
                newResult[i] = cCount;
            }

            return newResult;



        }
    }
}
