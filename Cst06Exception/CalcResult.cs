using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst06Exception
{
    internal class CalcResult
    {
        public CalcResult(int result, bool success)
        {
            Result = result;
            Success = success;
        }

        public int Result { get; set; }
        public bool Success { get; set; }
    }
}
