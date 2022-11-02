using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cst05objects
{
    internal class Student : object
    {
        private string firstname; // atributy, pasivní data, stav objektu
        private string lastname;
        private int grade = 1;
        private double markAgerage;

        // konstruktor
        public Student(string firstname, string lastname, int grade, double markAgerage)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.grade = grade;
            this.markAgerage = markAgerage;
        }

        public Student()
        {
            firstname = "Fred";
            lastname = "Skočdopole";
            markAgerage = 5;
        }

        public string GetFirstname()
        {
            return firstname;
        }
        public int GetGrade() // getter
        {
            return grade;
        }

        public int Advance()
        {
            if (grade < 4) { return ++grade; } else { return grade; }
            
        }

        //setter
        public void SetGrade(int value) // metoda, aktivní, mění stav objektu, přistupuje k privátním členům
        {
            if (value > 0 && value <= 4)
                grade = value;
        }

        public string GetFullname()
        {
            return firstname + " " + lastname;
        }

        public override string ToString()
        {
            return firstname + " " + lastname + " " + grade;
        }

    }
}
