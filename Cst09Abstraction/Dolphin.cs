using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09Abstraction
{
    internal class Dolphin : Entity, IGradeable
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public double SetGrade(double value)
        {
            Grade = value;
            return Grade;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
