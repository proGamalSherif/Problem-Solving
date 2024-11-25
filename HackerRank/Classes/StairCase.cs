using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class StairCase
    {
        public static void Run()
        {

            bool isRepeating = false;

            do
            {
                Console.Write("Please Write a number : ");
                int ch = int.Parse(Console.ReadLine());
                if (ch > 0)
                {
                    staircase(ch);
                }
                Console.Write("Would you like to try again ? (y / n ) : ");
                char chh = char.Parse(Console.ReadLine());

                if (chh == 'y')
                {
                    isRepeating = true;
                }
                else
                {
                    isRepeating = false;
                }

            } while (isRepeating);

            //staircase(6);

        }
        public static void staircase(int n)
        {  

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }


        }
    }
}
