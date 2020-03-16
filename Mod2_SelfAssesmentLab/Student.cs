using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssesmentLab
{
    class Student : Person
    {
        private int studentID;
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public Student(string name, int ID, int yy, int mm, int dd) : base(name, yy, mm, dd)
        {
            this.StudentID = ID;
        }
        public void TakeTest()
        {
            Console.WriteLine("Test taken.");
        }
        public override void GetStatus()
        {
            Console.WriteLine("[Student] Name: " + this.Name + " DOB: " + this.DOB.ToString() + " Age: " + this.Age + " ID: " + this.StudentID);
        }
    }
}
