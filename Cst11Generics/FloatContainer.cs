using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst11Generics
{
    internal class FloatContainer
    {
        public FloatContainer(float value)
        {
            Value = value;
        }

        public float Value { get; private set; }

        public float GetValue()
        {
            return Value;
        }
    }
}
