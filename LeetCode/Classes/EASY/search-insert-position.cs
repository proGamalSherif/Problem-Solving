using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class search_insert_position
    {
        public static void Run()
        {
            int[] nums = [1, 3, 5, 6];
            int target = 7;
            int result = SearchInsert(nums, target);
            Console.WriteLine(result);

        }
        public static int SearchInsert(int[] nums, int target)
        {

            if (nums.Contains(target))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        return i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > target)
                    {
                        return i;
                    }
                }
                return nums.Length;
            }
            return -1;
        }
    }
}
