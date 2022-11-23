using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst08Polymorphism
{
    internal class Student : Human
    {
        public double Grade { get; set; }

        public override string Fullname()
        {
            return "Student " + Name + " has " + Grade;
        }
    }
}
