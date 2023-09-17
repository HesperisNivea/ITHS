using PokeGame;

// Här instansieras klassen Pokemon och ett objekt av typen Pokemon läggs i variabeln pikachu
// Detta görs med en konstruktor i klassen Pokemon som har 2 parametrar, name och type.
Pokemon pikachu = new Pokemon("Pikachu", PokeTypes.Electric);
Trainer trainer = new Trainer();

// Här instansieras klassen Pokemon och ett objekt av typen Pokemon läggs i variabeln charmander
// Detta görs med en tom konstruktor och sedan tilldelas värden till Name och Type
Pokemon charmander = new Pokemon();
charmander.Name = "Charmander";
charmander.Type = PokeTypes.Fire;


Pokemon bellossom = new Pokemon("Bellossom",PokeTypes.Grass);
Pokemon chikorita = new Pokemon("Chikorita", PokeTypes.Grass);
Pokemon cherubi = new Pokemon("Cherubi", PokeTypes.Grass);
Pokemon pansage = new Pokemon("Pansage", PokeTypes.Grass);
Pokemon psyduck = new Pokemon("Spyduck", PokeTypes.Water);

//trainer.Catch(bellossom);
//trainer.Catch(chikorita);
//trainer.Catch(cherubi);
//trainer.Catch(pansage);
//trainer.Catch(psyduck);

trainer.Catch(cherubi,bellossom,chikorita,pansage,psyduck);

foreach (var p in trainer.PokemonCollection)
{
    Console.WriteLine(p.Name);
}

Console.WriteLine("------------------");
 for (int i = trainer.PokemonCollection.Count - 1; i >= 0 ; i--)
{
    Console.WriteLine(trainer.PokemonCollection[i].Name);
    trainer.PokemonCollection.RemoveAt(i);
}
Console.WriteLine("------------------");
Console.WriteLine(trainer.PokemonCollection.Count); // check
Console.WriteLine("------------------");
// Här anropas metoden Attack på objektet charmander och en referens till objektet pikachu skickas in som argument
charmander.Attack(pikachu);
// Här anropas metoden Attack på objektet pikachu och en referens till objektet charmander skickas in som argument
pikachu.Attack(charmander);

// Här skrivs värdet på propertyn HealthPoints ut för båda objekten pikachu och charmander
Console.WriteLine("Pikachu health points: " + pikachu.HealthPoints);
Console.WriteLine("Charmander health points: " + charmander.HealthPoints);

//Console.WriteLine(pikachu.Name);
//Console.WriteLine(pikachu.Type);
//Console.WriteLine(charmander.Name);
//Console.WriteLine(charmander.Type);

//charmander.Type = "tjoho0";

//Console.WriteLine(charmander.Name);
//Console.WriteLine(charmander.Type);