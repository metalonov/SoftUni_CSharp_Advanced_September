using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals;

public class Hen : Bird
{
    private const double weightIncrease = 0.35;
    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize) { }
    protected override double WeightMultiplier => weightIncrease;
    protected override IReadOnlyCollection<Type> PreferredFoodTypes
    => new HashSet<Type>() { typeof(Meat), typeof(Vegetable), typeof(Fruit), typeof(Seeds) };

    public override string ProduceSound()
        => "Cluck";
}
