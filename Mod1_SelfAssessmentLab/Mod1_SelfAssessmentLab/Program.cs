using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram InformationTechnology = new UProgram("Information Technology");

            Student stud1 = new Student("Ram", 201711, 11);
            Student stud2 = new Student("Shyam", 201712, 12);
            Student stud3 = new Student("Ajay", 201713, 13);

            Course course1 = new Course("Programming with C#", 101, 4);
            course1.SetStudent(stud1, 0);
            course1.SetStudent(stud2, 1);
            course1.SetStudent(stud3, 2);

            Teacher teacher1 = new Teacher("Ajeet", 10169);
            course1.teacherP = teacher1;

            Degree Bachelor = new Degree("Bachelor");
            Bachelor.courseP = course1;

            InformationTechnology.degreeP = Bachelor;

            Console.WriteLine($"Program: {InformationTechnology.Name}");
            Console.WriteLine($"Course: {InformationTechnology.degreeP.courseP.Name}");
            Console.WriteLine($"Student Count: {Student.StudentCount()}");
        }
    }
}
