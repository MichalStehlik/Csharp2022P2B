using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csc05AnimalFarm
{
    internal class Tiger : Animal, ICarnivore
    {
        public Tiger(double value, string name)
        {
            Energy = value;
            Name = name;
        }

        public double Energy { get; set; }
        
        public void Consume(Animal something)
        {
            if (something is IConsumable)
            {
                Energy += (something as IConsumable)!.Energy / 5;
            }
        }
        public override string ToString()
        {
            return "Tygřík " + base.ToString();
        }

    }
}
