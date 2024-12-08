using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ContainsDuplicateII
    {
        public static void Run()
        {
            int[] nums = [1, 0, 1, 1];
            int k = 1;
            bool result = ContainsNearbyDuplicate(nums, k);
            Console.WriteLine(result);
        }
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= i + k && j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
            return false; 
        }
    }

}
