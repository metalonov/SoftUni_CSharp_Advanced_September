using FoodShortage.Models;
using FoodShortage.Models.Interfaces;

namespace BorderControl;
public class StartUp
{
    static void Main()
    {
        List<IBuyer> buyersList = new();

        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (tokens.Length == 4)
            {
                IBuyer citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                buyersList.Add(citizen);
            }
            else
            {
                IBuyer rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                buyersList.Add(rebel);
            }

        }

        string buyer;
        while ((buyer = Console.ReadLine()) != "End")
        {
            buyersList.FirstOrDefault(person => person.Name == buyer)?.BuyFood();
        }

        Console.WriteLine(buyersList.Sum(b => b.Food));
    }
}
