using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09Abstraction
{
    internal sealed class Student : Human, IGradeable
    {
        public double Grade { get; set; }

        public double SetGrade(double value)
        {
            Grade = value;
            return Grade;
        }
    }
}
