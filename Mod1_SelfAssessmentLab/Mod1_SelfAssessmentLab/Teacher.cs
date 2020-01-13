using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmentLab
{
    class Teacher
    {
        private static int teacherCount = 0;
        public string Name { get; set; }
        public int ID { get; set; }
        public Teacher()
        {
            teacherCount++;
        }
        public Teacher(string name, int id)
        {
            this.Name = name;
            this.ID = id;
            teacherCount++;
        }
        public static int TeacherCount()
        {
            return teacherCount;
        }
    }
}
