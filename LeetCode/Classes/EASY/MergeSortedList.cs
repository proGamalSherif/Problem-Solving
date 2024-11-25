using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class MergeSortedList
    {
        public static void Run()
        {
            int[] nums1 = [1], nums2 = [];
            int m = 1, n = 0;

            Merge(nums1, m, nums2, n);



        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] mergedList = new int[m + n];
            int lastIndex = 0;
            for(int i=0;i < m; i++)
            {
                mergedList[lastIndex] = nums1[i];
                lastIndex++;
            }
            for(int j = 0; j < n; j++)
            {
                mergedList[lastIndex] = nums2[j];
                lastIndex++;
            }

            Array.Sort(mergedList);

            Console.WriteLine($"Merged List [{string.Join(",", mergedList)}]");
        }
    }
}
