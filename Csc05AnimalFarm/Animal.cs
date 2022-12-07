using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Csc05AnimalFarm
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    
}
