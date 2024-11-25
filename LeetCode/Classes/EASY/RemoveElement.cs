using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class RemoveElement
    {
        public static void Run()
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int result = RemoveElementx(nums, val);
            Console.WriteLine(result);
        }
        public static int RemoveElementx(int[] nums, int val)
        {
            int k = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i]; ;
                    k++;
                }
            }
            return k;
        }
    }
}
