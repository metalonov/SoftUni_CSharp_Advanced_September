namespace FootballTeamGenerator.Models;
public class Toppings
{
    private Dictionary<string, double> toppingTypes;
    private const double baseCalorie = 2;

    private string topping;
    private double weight;
    public Toppings(string topping, double weight)
    {
        toppingTypes
            = new Dictionary<string, double>
            {
                { "meat", 1.2 },
                { "veggies", 0.8 },
                { "cheese", 1.1},
                { "sauce", 0.9}
            };

        Topping = topping;
        Weight = weight;
    }

    public string Topping
    {
        get => topping;
        private set
        {
            if (!toppingTypes.ContainsKey(value.ToLower()))
            {
                string returnToUpper = $"{value[0].ToString().ToUpper()}{value.Substring(1)}";
                throw new ArgumentException($"Cannot place {returnToUpper} on top of your pizza.");
            }
            topping = value.ToLower();
        }
    }

    public double Weight
    {
        get => weight;
        private set
        {
            if (value < 0 || value > 50)
            {
                string returnToUpper = $"{Topping[0].ToString().ToUpper()}{Topping.Substring(1)}";
                throw new ArgumentException($"{returnToUpper} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }
    public double Calories
    {
        get
        {
            double toppingMod = baseCalorie * toppingTypes[Topping.ToLower()] * weight;
            return toppingMod;
        }
    }
}
