namespace PokemonTrainer;
internal class StartUp
{
    static void Main()
    {
        List<Trainer> trainers = new();

        string command;
        while ((command = Console.ReadLine()) != "Tournament")
        {
            string[] tokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string trainerName = tokens[0];
            Pokemon pokemon = new(tokens[1], tokens[2], int.Parse(tokens[3]));
            Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);
            if (trainer == null)
            {
                trainer = new Trainer(trainerName);
                trainers.Add(trainer);
                trainer.Pokemons.Add(pokemon);
            } 
            else
            {
                trainer.Pokemons.Add(pokemon);
            }
        }

        string element;
        while ((element = Console.ReadLine()) != "End")
        {
            foreach (Trainer trainer in trainers)
            {
                if (trainer.Pokemons.Any(x => x.Element == element))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    trainer.ReducePokemonHealth();
                }
                trainer.RemoveDead();
            }
        }

        var sortedByBadges = trainers.OrderByDescending(x => x.NumberOfBadges);

        foreach (Trainer trainer in sortedByBadges)
        {
            Console.WriteLine(trainer.ToString());
        }
    }
}
