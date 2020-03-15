using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class TechnicalEmployee : Employee
    {
        public TechnicalEmployee(string name) : base(name, 75000)//calling base class constructor from derived class constructor
        {

        }

        public int successfulCheckIns = 5;

        public override string employeeStatus()//overriding the method for class specific implementation
        {
            return this.toString() + " has " + this.successfulCheckIns + " successful check ins.";
        
        }
    }
}
