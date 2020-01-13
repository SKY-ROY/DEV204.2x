using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an object of class Car
            var Car1 = new Car();
            //using dot notation to set values through set properties
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;
            //use of get properties to access the values of the private members
            Console.WriteLine("Color: " + Car1.Color);
            Console.WriteLine("Year of Manf.: " + Car1.Year.ToString());
            Console.WriteLine("Mileage: " + Car1.Mileage.ToString());

            Console.WriteLine($"This {Car1.Color} car is manufactured in year {Car1.Year} and has {Car1.Mileage} KM on it.");
        }
        //Class Declaration
        public class Car
        {
            //Defining Properties
            public string Color { get; set; }
            public int Year { get; set; }
            public int Mileage { get; set; }
        }
    }
}
