using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ParkingSystem
    {
        private int largeSlot;
        private int mediumSlot;
        private int smallSlot;
        public ParkingSystem(int _large, int _medium, int _small)
        {
            largeSlot = _large;
            mediumSlot = _medium;
            smallSlot = _small;
        }
        public static void Run()
        {
            ParkingSystem park1 = new ParkingSystem(3, 3, 0);
            Console.WriteLine(park1.AddCar(1));
            Console.WriteLine(park1.AddCar(1));
            Console.WriteLine(park1.AddCar(1));
            Console.WriteLine(park1.AddCar(1));
            Console.WriteLine(park1.AddCar(1));
        }
        public bool AddCar(int carType)
        {
            if (carType == 1)
            {
                if (largeSlot > 0)
                {
                    largeSlot--;
                    return true;
                }
            }
            else if (carType == 2)
            {
                if (mediumSlot > 0)
                {
                    mediumSlot--;
                    return true;
                }
            }
            else if (carType == 3)
            {
                if (smallSlot > 0)
                {
                    smallSlot--;
                    return true;
                }
            }
            return false;
        }
    }
}
