using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class GradingStudents
    {
        public static void Run()
        {
            List<int> grades = new List<int>{73, 67, 38, 33};
            List<int> result = gradingStudents(grades);
            Console.WriteLine($"[{string.Join(",", result)}]");
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> returnedList = new List<int>();
            for(int g = 0; g < grades.Count; g++)
            {
                int currentDegree=grades[g];
                int dividableDegree = getDivisibleNumber(currentDegree);
                if (dividableDegree >= 40)
                {
                    int diff = dividableDegree - currentDegree;
                    if (diff < 3)
                    {
                        returnedList.Add(dividableDegree);
                    }
                    else
                    {
                        returnedList.Add(currentDegree);
                    }
                }
                else
                {
                    returnedList.Add(currentDegree);
                }
            }
            return returnedList;
        }
        static bool isDivisableByFive(int num)
        {
            return num % 5 == 0;
        }
        static int getDivisibleNumber(int num)
        {
            int returnedNumber = num;
            bool isDivisible = isDivisableByFive(num);
            while (!isDivisible)
            {
                returnedNumber++;
                isDivisible = isDivisableByFive(returnedNumber);
            }
            return returnedNumber;
        }
    }
}
