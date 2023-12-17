using WildFarm.Models.Foods;
namespace WildFarm.Models.Animals;
public class Dog : Mammal
{
    private const double dogWeightInrease = 0.40;
    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion) { }
    protected override IReadOnlyCollection<Type> PreferredFoodTypes
        => new HashSet<Type>() { typeof(Meat) };

    protected override double WeightMultiplier
        => dogWeightInrease;

    public override string ProduceSound()
        => "Woof!";
    public override string ToString()
        => $"{Weight}, {LivingRegion}, {FoodEaten}]";
}
