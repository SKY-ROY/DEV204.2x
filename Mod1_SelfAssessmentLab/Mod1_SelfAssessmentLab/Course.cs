using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmentLab
{
    class Course
    {
        static int courseCount = 0;
        public string Name { get; set; }
        public int Code { get; set; }
        public int Credits { get; set; }

        private Student[] stud = new Student[3];
        public void SetStudent(Student studArg, int i)
        {
            stud[i] = studArg;
        }

        public Teacher teacherP { get; set; }


        public Course(string name, int code, int credits)
        {
            this.Name = name;
            this.Code = code;
            this.Credits = credits;
            courseCount++;
        }

    }
}
