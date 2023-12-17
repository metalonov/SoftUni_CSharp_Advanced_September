using WildFarm.Core.Interfaces;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core;
public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWriter writer;
    private readonly IAnimalFactory animalFactory;
    private readonly IFoodFactory foodFactory;

    private readonly ICollection<IAnimal> animals;
    public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
    {
        this.reader = reader;
        this.writer = writer;
        this.animalFactory = animalFactory;
        this.foodFactory = foodFactory;
        animals = new List<IAnimal>();
    }

    public void Run()
    {
        string command;

        while ((command = reader.ReadLine()) != "End")
        {
            IAnimal animal = null;
            try
            {
                animal = CreateAnimal(command);
                IFood food = CreateFood();
                Console.WriteLine(animal.ProduceSound());
                animal.Eat(food);
            }
            catch (ArgumentException ex)
            {
                writer.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }
            animals.Add(animal);
        }

        foreach (IAnimal animal in animals)
        {
            writer.WriteLine(animal.ToString());
        }
    }

    private IAnimal CreateAnimal(string command)
    {
        string[] tokens = command
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        IAnimal animal = animalFactory.CreateAnimal(tokens);

        return animal;
    }

    private IFood CreateFood()
    {
        string[] tokens = reader.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        IFood food = foodFactory.CreateFood(tokens);

        return food;
    }
}

/*
Cat Sammy 1.1 Home Persian
Vegetable 4
End
*/

/*
Tiger Rex 167.7 Asia Bengal
Vegetable 1
Dog Tommy 500 Street
Vegetable 150
End
*/

/*
Mouse Jerry 0.5 Anywhere
Fruit 1000
Owl Tom 2.5 30
Meat 5
End
*/
