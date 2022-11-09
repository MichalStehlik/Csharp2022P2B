using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst06Exception
{
    internal class ErrorMaker
    {
        public ErrorMaker(int value)
        {
            Value = value;
        }

        public int AddValue(int number)
        {
            if (number < 0) 
                Console.WriteLine("CHYBA");
            else
            {
                Value += number;
                
            }
            return Value;
        }

        public int AddValue2(int number)
        {
            if (number < 0)
                return -1; // nesmyslná konstanta
            else
            {
                Value += number;
                return Value;
            }
        }
        public bool AddValue2(int number, out int result)
        {
            if (number < 0)
            {
                result = 0;
                return false;
            }      
            else
            {
                Value += number;
                result = Value;
                return true;
            }
        }

        public CalcResult AddValue3(int number)
        {
            if (number < 0)
                return new CalcResult(Value, false);
            else
            {
                Value += number;
                return new CalcResult(Value, true);
            }
        }

        public int AddValue4(int number)
        {
            if (number == 0)
            {
                throw new StupidUserException("No brain present in target head.");
            }
            if (number < 0)
                throw new ArgumentException("Number is below zero.");
            else
            {
                Value += number;
                return Value;
            }
        }

        public int Value { get; private set; }
    }
}
