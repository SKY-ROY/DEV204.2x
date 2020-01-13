using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmentLab
{
    class Student
    {
        private static int studentCount = 0;
        public string Name { get; set; }
        public int EnrNum { get; set; }
        public int RollNum { get; set; }
        public Student()
        {
            studentCount++;
        }
        public Student(string name, int enrNum, int rollNum)
        {
            this.Name = name;
            this.EnrNum = enrNum;
            this.RollNum = rollNum;
            studentCount++;
        }
        public static int StudentCount()
        {
            return studentCount;
        }
    }
}
