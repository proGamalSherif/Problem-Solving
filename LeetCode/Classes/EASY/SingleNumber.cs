﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class SingleNumber
    {
        public static void Run()
        {
            int[] nums = [1];
            int result = SingleeNumber(nums);
            Console.WriteLine(result);
        }
        public static int SingleeNumber(int[] nums)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (countMap.ContainsKey(nums[i]))
                {
                    countMap[nums[i]]++;
                }
                else
                {
                    countMap[nums[i]] = 1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (countMap[nums[i]] == 1)
                {
                    return nums[i];
                }
            }

            return 0;
        }
    }
}