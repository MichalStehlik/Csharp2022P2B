using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09Abstraction
{
    internal class Human : Entity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public override string Name { get { return Firstname + " " + Lastname; } }
        public string ToString()
        {
            return Name;
        }
    }
}
