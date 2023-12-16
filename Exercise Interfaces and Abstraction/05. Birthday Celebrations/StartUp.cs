using FoodShortage.Models;
using FoodShortage.Models.Interfaces;

namespace BorderControl;
public class StartUp
{
    static void Main()
    {
        List<IBirthable> peopleWhoPassedTheBorder = new();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string entityType = tokens[0];
            switch (entityType)
            {
                case "Citizen":
                    IBirthable citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    peopleWhoPassedTheBorder.Add(citizen);
                    break;
                case "Pet":
                    IBirthable pet = new Pet(tokens[1], tokens[2]);
                    peopleWhoPassedTheBorder.Add(pet);
                    break;
            }
        }

        string birthdayEndingWith = Console.ReadLine();

        foreach (var item in peopleWhoPassedTheBorder)
        {
            if (item.Birthdate.EndsWith(birthdayEndingWith.ToString()))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }
}
