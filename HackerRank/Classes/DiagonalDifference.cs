using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class DiagonalDifference
    {
        public static void Run()
        {

            List<List<int>> arr= new List<List<int>>();
            //11 2 4
            //4 5 6
            //10 8 - 12

            arr.Add(new List<int> { 11, 2, 4 });
            arr.Add(new List<int> { 4, 5, 6 });
            arr.Add(new List<int> { 10, 8, -12 });



            int result = diagonalDifference(arr); ;

            Console.WriteLine($"Result {result}");


        }
        static int diagonalDifference(List<List<int>> arr)
        {
            int n = arr.Count();
            int firstDiagonal = 0;
            int secondDiagonal = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                firstDiagonal += arr[i][i];
                secondDiagonal += arr[i][n - i - 1];
            }
            return (int)(Math.Abs(firstDiagonal - secondDiagonal));

        }
    }
}
