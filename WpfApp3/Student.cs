using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Student
    {
        public string imie;
        public string nazwisko;

        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return "Imię: " + imie + ", nazwisko: " + nazwisko;
        }
    }


}
