using BorderControl.Models;
using BorderControl.Models.Interfaces;

namespace BorderControl;
public class StartUp
{
    static void Main()
    {
        List<IIdentifiable> peopleWhoPassedTheBorder = new();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (tokens.Length == 3)
            {
                string citizenName = tokens[0];
                int citizenAge = int.Parse(tokens[1]);
                string citizenId = tokens[2];
                Person citizen = new(citizenName, citizenAge, citizenId);
                peopleWhoPassedTheBorder.Add(citizen);
            }
            else if (tokens.Length == 2)
            {
                string robotModel = tokens[0];
                int robotAge = 0;
                string robotId = tokens[1];
                Person robot = new(robotModel, robotAge, robotId);
                peopleWhoPassedTheBorder.Add(robot);
            }
        }

        string fakeId = Console.ReadLine();

        foreach (var item in peopleWhoPassedTheBorder)
        {
            if (item.Id.EndsWith(fakeId.ToString()))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
