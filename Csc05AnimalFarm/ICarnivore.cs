using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csc05AnimalFarm
{
    internal interface ICarnivore
    {
        void Consume(Animal something);
        double Energy { get; set; }
    }
}
