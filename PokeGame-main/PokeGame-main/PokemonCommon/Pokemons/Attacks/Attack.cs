using PokemonCommon.Enums;

namespace PokemonCommon.Pokemons.Attacks;

public abstract class Attack
{
    public double Damage { get; }

    public string Name { get; set; }

    public PokeTypes Type { get; set; }

    protected Attack(double damage, string name, PokeTypes type)
    {
        Damage = damage;
        Name = name;
        Type = type;
    }
}


