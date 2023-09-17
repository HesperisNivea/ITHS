using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeGame
{
    internal class Trainer
    {
        public List<Pokemon> PokemonCollection { get; set; } // = new PokemonCollection<>();

        public Trainer()
        { 
            PokemonCollection = new List<Pokemon>();
        }
        public void Catch( params Pokemon[] pokemon) //params?
        {
            for (int i = 0; i < pokemon.Length; i++)
            {
                PokemonCollection.Add(pokemon[i]);
            }
        }
        public void Release(Pokemon pokemon)
        {
            PokemonCollection.Remove(pokemon);
        }
        // Detta är en statisk metod. Statiska metoder anropas via typen och inte via objekt.
        public static void Greeting() 
        {
            Console.WriteLine("Hi!");
        }
    }
}
