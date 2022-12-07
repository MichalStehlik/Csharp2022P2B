using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csc05AnimalFarm
{
    internal class Pig : Animal, IConsumable, IHerbivore, ICarnivore
    {
        public Pig(double value, string name)
        {
            Energy = value;
            Name = name;
        }

        public double Energy { get; set; }

        public void Consume(Plant something)
        {
            if (something is IConsumable)
            {
                Energy += (something as IConsumable)!.Energy / 10;
            }
        }

        public void Consume(Animal something)
        {
            if (something is IConsumable)
            {
                Energy += (something as IConsumable)!.Energy / 5;
            }
        }
        public override string ToString()
        {
            return "Prasátko " + base.ToString();
        }

    }
}
