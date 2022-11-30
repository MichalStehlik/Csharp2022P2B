using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09Abstraction
{
    internal interface IGradeable
    {
        double Grade { get; set; }

        double SetGrade(double value);
    }
}
