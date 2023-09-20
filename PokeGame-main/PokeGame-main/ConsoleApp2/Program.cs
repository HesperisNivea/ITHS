using PokemonCommon.Pokemons;
using PokemonCommon.Characters;
using PokemonCommon.Enums;

Pokemon sunflora = new Pokemon("SunFlora", PokeTypes.Grass);
Pokemon goomy = new Pokemon("Goomy", PokeTypes.Dragon);
Trainer romeo = new Trainer();

romeo.Catch(sunflora, goomy);



foreach (var pokemon in romeo.PokemonCollection)
{
   
}


