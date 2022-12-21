using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst11Generics
{
    internal class IntContainer
    {
        public IntContainer(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public int GetValue()
        {
            return Value;
        }
    }
}
