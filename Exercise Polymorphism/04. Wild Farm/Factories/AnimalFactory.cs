using System.ComponentModel;
using WildFarm.Factories.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories;

public class AnimalFactory : IAnimalFactory
{
    public IAnimal CreateAnimal(string[] tokens)
    {
        switch (tokens[0])
        {
            case "Dog":
                return new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
            case "Mouse":
                return new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
            case "Cat":
                return new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
            case "Hen":
                return new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
            case "Owl":
                return new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
            case "Tiger":
                return new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
            default:
                throw new InvalidEnumArgumentException("Invalid animal type.");

        }
    }
}
