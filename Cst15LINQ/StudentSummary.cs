using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst15LINQ
{
    internal class StudentSummary
    {
        public string Classroom { get; set; }
        public int Count { get; set; }
        public double Average { get; set; }
        public override string ToString()
        {
            return Classroom + " " + Count + " " + Average;
        }
    }
}
