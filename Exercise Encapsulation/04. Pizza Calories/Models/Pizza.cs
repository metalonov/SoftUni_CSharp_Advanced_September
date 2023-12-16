using FootballTeamGenerator.Exceptions;

namespace FootballTeamGenerator.Models;

public class Pizza
{
    private string name;
    private List<Toppings> toppings;
    public Pizza(string name, Dough dough)
    {
        Name = name;
        Dough = dough;

        toppings = new List<Toppings>();
    }

    public string Name
    {
        get => name;
        set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPizzaName);
            }
            name = value;
        }
    }

    public Dough Dough { get; set; }

    public double Calories
    {
        get
        {
            return Dough.Calories + toppings.Sum(c => c.Calories);
        }
    }

    public void AddTopping(Toppings topping)
    {
        if (toppings.Count == 10)
        {
            throw new ArgumentException(ExceptionMessages.TooMuchTopping);
        }
        toppings.Add(topping);
    }

    public override string ToString() => $"{Name} - {Calories:f2} Calories.";
}
