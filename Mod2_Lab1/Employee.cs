using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        //public properties
        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public double BaseSalary
        {
            get { return employeeBaseSalary; }
            set { employeeBaseSalary = value; }
        }
        public int ID
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        private static int employeeCount = 1;
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.ID;
        }
        public string toString()
        {
            return this.ID + " " + this.Name;
        }
        //abstract function that must be re-implemented in derived class
        public abstract string employeeStatus();

        //virtual function that can be re-implemented in derived class
        /*
        public virtual string employeeStatus()
        {
            return toString() + " is in the company's system.";
        }
        */
}
}
