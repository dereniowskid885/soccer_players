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
        public int Height { get; set; }
        public string Club { get; set; }

        public Player(string name, string surname, int age, int weight, int height, string club)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;
            Club = club;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age} lat, {Weight} kg, {Height} cm, {Club}";
        }

        public override bool Equals(object obj)
        {
            var p = obj as Player;
            if (p == null) return false;
            if (p.Name != this.Name) return false;
            if (p.Surname != this.Surname) return false;
            if (p.Age != this.Age) return false;
            if (p.Club != this.Club) return false;
            return true;
        }
    }
}
