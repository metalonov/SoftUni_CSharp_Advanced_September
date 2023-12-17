using System.ComponentModel;
using WildFarm.Factories.Interfaces;
using WildFarm.Models.Foods;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories;

public class FoodFactory : IFoodFactory
{
    public IFood CreateFood(string[] arguments)
    {
        switch (arguments[0])
        {
            case "Meat":
                return new Meat(int.Parse(arguments[1]));
            case "Fruit":
                return new Fruit(int.Parse(arguments[1]));
            case "Vegetable":
                return new Vegetable(int.Parse(arguments[1]));
            case "Seeds":
                return new Seeds(int.Parse(arguments[1]));
            default:
                throw new InvalidEnumArgumentException("Invalid food type.");
        }
    }
}
