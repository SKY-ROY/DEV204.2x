﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiaitng object
            var Car1 = new Car("Red", 2008);
            var Car2 = new Car(2008, 10000);
            var Car3 = new Car();

            Car3.Color = "WHITE";
            Car3.Year = 2010;
            Car3.Mileage = 11000;

            int carCount = Car.CountCars();

            Console.WriteLine($"Number of Cars in inventory: {carCount}");
        }
    }
}
