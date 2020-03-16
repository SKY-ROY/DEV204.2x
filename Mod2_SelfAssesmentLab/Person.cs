using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssesmentLab
{
    abstract class Person
    {
        //private variables
        private string name;
        private DateTime dob;
        private int age;
        //public properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //parameterized constructor
        public Person(string name, int YY, int MM, int DD)
        {
            this.Name = name;
            this.DOB = new DateTime(YY, MM, DD);
            this.Age = CalcAge(this.DOB/*new DateTime(YY, MM, DD)*/);
        }
        private int CalcAge(DateTime dobArg)
        {
            int currYear = System.DateTime.Now.Year , currMonth = System.DateTime.Now.Month, currDate = System.DateTime.Now.Day;
            int birthYear = dobArg.Year, birthMonth = dobArg.Month, birthDate = dobArg.Day;
            int calculatedAge_year, calculatedAge_month, calculatedAge_day;
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};//array for number days in corresponding month 

            if(birthDate > currDate)
            {
                currDate += months[birthMonth - 1];
                currMonth -= 1;
            }
            if(birthMonth > currMonth)
            {
                currMonth += 12;
                currYear -= 1;
            }

            calculatedAge_year = currYear - birthYear;
            calculatedAge_month = currMonth - birthMonth;
            calculatedAge_day = currDate - birthDate;

            return calculatedAge_year;
        }
        //abstract methods
        public abstract void GetStatus();
        //getter methods
        public string GetName() { return Name; }
        public DateTime GetDOB() { return DOB; }
        public int GetAge() { return Age; }
    }
}
