using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals;

public class Mouse : Mammal
{
    private const double weightIncrease = 0.10;

    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }
    protected override double WeightMultiplier => weightIncrease;
    protected override IReadOnlyCollection<Type> PreferredFoodTypes
        => new HashSet<Type>() { typeof(Vegetable), typeof(Fruit) };
    public override string ProduceSound() => "Squeak";
    public override string ToString()
    {
        return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
