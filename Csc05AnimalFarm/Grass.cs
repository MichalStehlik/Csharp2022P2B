﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csc05AnimalFarm
{
    internal class Grass : Plant, IConsumable
    {
        public Grass(double energy)
        {
            Energy = energy;
        }

        public double Energy { get; private set; }

        public override string ToString()
        {
            return "Tráva";
        }
    }
}
