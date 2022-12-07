using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst10OperatorOverloading
{
    internal class Number
    {
        public Number(double value)
        {
            Value = value;
        }

        public double Value { get; set; }

        public static Number operator + (Number a, int value)
        {
            return new Number(a.Value + value);
        }
        public static Number operator +(Number a, Number b)
        {
            return new Number(a.Value + b.Value);
        }
        public static Number operator +(int value, Number b)
        {
            return new Number(value + b.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
