using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ConcatenationofArray
    {
        public static void Run()
        {

            int[] nums = { 1, 2, 1 };
            int[] result = GetConcatenation(nums);
            Console.WriteLine($"[{string.Join(",", result)}]");

        }
        public static int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                result[i] = nums[i];
                result[i + n] = nums[i];
            }
            return result;
        }
    }
}
