using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessmentLab
{
    class Degree
    {
        public string Level { get; set; }
        public Course courseP { get; set; }

        public Degree(string level)
        {
            this.Level = level;
        }
    }
}
