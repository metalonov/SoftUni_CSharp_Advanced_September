using WildFarm.Models.Foods;
namespace WildFarm.Models.Animals;
public class Cat : Feline
{
    private const double catWeightMultipiler = 0.30;

    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed) { }

    protected override double WeightMultiplier
        => catWeightMultipiler;
    protected override IReadOnlyCollection<Type> PreferredFoodTypes
        => new HashSet<Type>() { typeof(Meat), typeof(Vegetable) };

    public override string ProduceSound()
        => "Meow";
}
