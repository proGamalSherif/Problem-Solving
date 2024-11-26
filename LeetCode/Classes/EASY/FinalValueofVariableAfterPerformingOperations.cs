using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class FindValuesAfterPerfom
    {
        public static void Run()
        {
            string[] operations = ["--X", "X++", "X++"];
            int result = FinalValueAfterOperations(operations);
            Console.WriteLine(result);
        }
        public static int FinalValueAfterOperations(string[] operations)
        {
            int result = 0;
            for(int i =0;i<operations.Length;i++)
            {
                string currentString = operations[i];
                if (!currentString.StartsWith("X"))
                {
                    if (currentString.StartsWith("++"))
                    {
                        ++result;
                    }
                    else if (currentString.StartsWith("--"))
                    {
                        --result;
                    }
                }
                else
                {
                    if (currentString.EndsWith("++"))
                    {
                        result++;
                    }
                    else if (currentString.EndsWith("--"))
                    {
                        result--;
                    }
                }
            }
            return result;
        }
    }
}
