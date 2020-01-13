using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
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

    public class Car
    {
        private static int instances = 0;
        //Properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        
        public Car()
        {
            instances++;
        }
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }
        public static int CountCars()
        {
            return instances;
        }
    }
}
