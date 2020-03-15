using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new TechnicalEmployee("Libby");
            var employee2 = new TechnicalEmployee("Zaynah");
            var employee3 = new BusinessEmployee("Vince");

            Console.WriteLine(employee1.employeeStatus());
            Console.WriteLine(employee2.employeeStatus());
            Console.WriteLine(employee3.employeeStatus());
        }
    }
}
