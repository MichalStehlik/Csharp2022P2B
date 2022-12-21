using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst11Generics
{
    internal class StringContainer
    {
        public StringContainer(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }

        public string GetValue()
        {
            return Value;
        }
    }
}
