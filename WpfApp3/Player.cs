using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Player
    {
        /*private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }*/

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public Player(string name, string surname, int age, int weight)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age} lat, {Weight} kg";
        }
    }
}
