using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssesmentLab
{
    class Teacher : Person
    {
        private int teacherID;
        public int TeacherID
        {
            get { return teacherID; }
            set { teacherID = value; }
        }
        public Teacher(string name, int ID, int yy, int mm, int dd) : base(name, yy, mm, dd)
        {
            this.TeacherID = ID;
        }
        public void GradeTest()
        {
            Console.WriteLine("Test graded.");
        }
        public override void GetStatus()
        {
            Console.WriteLine("[Teacher] Name: " + this.Name + " DOB: " + this.DOB.ToString() + " Age: " + this.Age + " ID: " + this.TeacherID);
        }
    }
}
