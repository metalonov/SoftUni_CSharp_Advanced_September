using FootballTeamGenerator.Core.Interfaces;
using FootballTeamGenerator.Factories.Interfaces;
using FootballTeamGenerator.IO.Interfaces;
using FootballTeamGenerator.Models;

namespace FootballTeamGenerator.Core;
public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWriter writer;
    private readonly IItemFactory vehicleFactory;
    public Engine(IReader reader, IWriter writer, IItemFactory vehicleFactory)
    {
        this.reader = reader;
        this.writer = writer;
        this.vehicleFactory = vehicleFactory;
    }

    public void Run()
    {
        try
        {
            string[] pizzatokens = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] doughtokens = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string pizzaname = pizzatokens[1];

            Dough dough = new(doughtokens[1], doughtokens[2], double.Parse(doughtokens[3]));
            Pizza pizza = new(pizzaname, dough);

            string toppingsinput;
            while ((toppingsinput = reader.ReadLine()) != "END")
            {
                string[] toppingTokens = toppingsinput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Toppings topping = new(toppingTokens[1], double.Parse(toppingTokens[2]));

                pizza.AddTopping(topping);
            }
            writer.WriteLine(pizza);
        }
        catch (Exception ex)
        {
            writer.WriteLine(ex.Message);
        }
    }
}

