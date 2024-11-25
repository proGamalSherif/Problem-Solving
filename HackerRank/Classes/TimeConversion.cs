using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    internal class TimeConversion
    {
        public static void Run()
        {
            string s = "12:01:00PM";
            string rs = timeConversion(s);
            Console.WriteLine(rs);
            s = "12:01:00AM";
            rs = timeConversion(s);
            Console.WriteLine(rs);
        }
        public static string timeConversion(string s)
        {
            int hours = int.Parse(s.Substring(0, 2));
            int minute = int.Parse(s.Substring(3, 2));
            int seconds = int.Parse(s.Substring(6, 2));
            string format = s.Substring(s.Length - 2, 2);

            if (format.ToLower() == "am")
            {
                if (hours == 12)
                {

                    TimeSpan ts = new TimeSpan(0, minute, seconds);
                    return ts.ToString();
                }
                else
                {
                    TimeSpan ts = new TimeSpan(hours, minute, seconds);
                    return ts.ToString();
                }
            }
            else if(format.ToLower() == "pm")
            {
                if(hours == 12)
                {
                    TimeSpan ts = new TimeSpan(hours, minute, seconds);
                    return ts.ToString();
                }
                else
                {
                    hours += 12;
                    TimeSpan ts = new TimeSpan(hours, minute, seconds);
                    return ts.ToString();
                }
               
            }
            else
            {
                return "Null";
            }
        }
    }
}
