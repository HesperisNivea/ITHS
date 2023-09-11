using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonClassEx
{
    internal class Pokemon
    {
        private string _name;
        public string Name { get; set; }

        private EnumPokeTypes _type;
        public EnumPokeTypes Type { get; set; }

        public Pokemon()
        {

        }
        public Pokemon(string name, EnumPokeTypes type)
        {
            _name = name;
            _type = type;
        }

        


        public static void Attack()
        {
            Console.WriteLine("Attack!!");
        }

        public override string ToString()
        {
            return "Name: " + _name + " Type: " + _type;
        }
    }
}
