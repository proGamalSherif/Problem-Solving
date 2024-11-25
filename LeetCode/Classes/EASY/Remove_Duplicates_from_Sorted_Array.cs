using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class Remove_Duplicates_from_Sorted_Array
    {
        public static void Run()
        {

            int[] nums = { 1, 1, 2 };
            int k = RemoveDuplicates(nums);
            Console.WriteLine(k);

        }
        static int RemoveDuplicates(int[] nums)
        {

            if (nums == null || nums.Length == 0)
                return 0;


            int uniqueIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[uniqueIndex])
                {
                    uniqueIndex++;
                    nums[uniqueIndex] = nums[i];
                }
            }


            return uniqueIndex + 1;

        }
    }
}
