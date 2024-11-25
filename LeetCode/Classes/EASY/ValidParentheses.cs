using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ValidParentheses
    {
        public static void Run()
        {
            string s = "{[(])}";
            bool sIsValid = IsValid(s);
            if (sIsValid)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
        public static bool IsValid(string s)
        {

            Dictionary<char, char> allowedChars = new Dictionary<char, char>
            {
                {'}','{' },
                {']','[' },
                {')','(' }
            };
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (allowedChars.ContainsKey(c))
                {
                    char topElement = stack.Count > 0 ? stack.Pop() : '#';
                    if (topElement != allowedChars[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }
    }
}
