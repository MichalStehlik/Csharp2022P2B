using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst09Abstraction
{
    internal abstract class Entity
    {
        public virtual string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
