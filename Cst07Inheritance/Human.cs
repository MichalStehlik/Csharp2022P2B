using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst07Inheritance
{
    internal class Human //: object
    {
        protected int _shoeSize;
        public Human() : this("Xaver","Xavier")
        {
        }

        public Human(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
            Console.WriteLine("Human is born.");
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public override string ToString()
        {
            return Firstname + "_" + Lastname;
        }
    }
}
