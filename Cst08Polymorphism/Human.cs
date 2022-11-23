using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst08Polymorphism
{
    internal class Human // : object
    {
        public string Name { get; set; }
        public virtual string Fullname()
        {
            return "Common human being " + Name;
        }

        public override string ToString()
        {
            return Fullname();
        }
    }
}
