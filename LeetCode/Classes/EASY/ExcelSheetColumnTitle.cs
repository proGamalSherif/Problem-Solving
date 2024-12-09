using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ExcelSheetColumnTitle
    {
        public static void Run()
        {
            int columnNumber = 27;
            string result = ConvertToTitle(columnNumber);
            Console.WriteLine(result);  
        }
        public static string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new StringBuilder();
            while (columnNumber > 0)
            {
                columnNumber--;
                char currentChar = (char)('A' + (columnNumber % 26));
                sb.Insert(0, currentChar);
                columnNumber /= 26;
            }
            return sb.ToString();
        }
    }
}
