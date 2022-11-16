using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst07Inheritance
{
    internal class Student : Human
    {
        public Student() : this("Zoltan","Zero","Z1")
        {
        }

        public Student(string firstname, string lastname, string classname)
            : base(firstname, lastname)
        {
            Classname = classname;
            Console.WriteLine("Its a Student " + Firstname );
        }

        public string Classname { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + Classname + " " + _shoeSize;
        }
    }
}
