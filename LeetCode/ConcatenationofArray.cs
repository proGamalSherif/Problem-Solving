using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
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
            //int count = nums.Length;
            //count *= 2;
            //int[] result = new int[count];
            //int lastIndex = 0;
            //for(int x = 0;x < 2; x++)
            //{
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        result[lastIndex] = nums[i];
            //        lastIndex++;
            //    }
            //}
            //return result;
            int n = nums.Length;
            int[] result=new int[n*2];
            for (int i = 0;i< n;i++)
            {
                result[i]=nums[i];
                result[i + n] = nums[i];
            }
            return result;
        }
    }
}
