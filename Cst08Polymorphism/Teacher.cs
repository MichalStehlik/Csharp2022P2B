using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cst08Polymorphism
{
    internal class Teacher : Human
    {
        public string Shortname { get; set; }

        public override string Fullname()
        {
            return "Teacher " + Name + " is known as " + Shortname;
        }
    }
}
