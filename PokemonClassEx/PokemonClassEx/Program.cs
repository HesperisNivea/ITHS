using PokemonClassEx;

Pokemon pikachu = new Pokemon("Pikachu", EnumPokeTypes.Electric);

Pokemon charmander = new Pokemon();
charmander.Name = "Charmender";
charmander.Type = (EnumPokeTypes)1;
Console.WriteLine(pikachu);
Console.WriteLine(charmander);
Pokemon.Attack();