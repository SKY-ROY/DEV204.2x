using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmentLab
{
    class UProgram
    {
        public string Name { get; set; }
        public Degree degreeP { get; set; }
        public UProgram(string name)
        {
            this.Name = name;
        }
    }
}
