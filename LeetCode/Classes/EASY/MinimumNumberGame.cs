using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class MinimumNumberGame
    {
        public static void Run()
        {
            int[] nums = [5, 4, 2, 3];
            int[] result = NumberGame(nums);
            Console.WriteLine($"[{string.Join(",", result)}]");

        }
        public static int[] NumberGame(int[] nums)
        {
            List<int> arr = nums.ToList();

            arr.Sort();

            List<int> result = new List<int>();
            List<int> arrAlice = new List<int>();
            List<int> arrBob = new List<int>();

            int lastChoice = 1; 

            while (arr.Count > 0)
            {
                if (lastChoice == 0)
                {
                    arrBob.Add(arr[0]);
                    lastChoice = 1; 
                }
                else
                {
                    arrAlice.Add(arr[0]);
                    lastChoice = 0; 
                }
                arr.RemoveAt(0);
            }

            for (int i = 0; i < arrAlice.Count; i++)
            {
                if (i < arrBob.Count)
                {
                    result.Add(arrBob[i]);
                }
                result.Add(arrAlice[i]);
            }

            return result.ToArray();
        }
    }
}
