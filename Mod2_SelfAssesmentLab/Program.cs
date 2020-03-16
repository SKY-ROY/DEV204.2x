using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssesmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Prof. Seri", 16022020, 1988, 02, 02);
            Student s1 = new Student("Sky", 01121999, 1998, 06, 05);
            
            t1.GetStatus();
            s1.GetStatus();
        }
    }
}
