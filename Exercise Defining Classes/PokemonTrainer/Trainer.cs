namespace PokemonTrainer;
public class Trainer
{

    public Trainer(string name)
    {
        Name = name;
        NumberOfBadges = 0;
        Pokemons =  new List<Pokemon>();
    }

    public string Name { get; set; }
    public int NumberOfBadges { get; set; }
    public List<Pokemon> Pokemons { get; }

    public void ReducePokemonHealth()
    {
        foreach (Pokemon pokemon in Pokemons)
        {
            pokemon.Health -= 10;
        }
    }

    public void RemoveDead()
    {
        Pokemons.RemoveAll(x => x.Health <= 0);
    }

    public override string ToString()
    {
        return $"{Name} {NumberOfBadges} {Pokemons.Count}";
    }
}
