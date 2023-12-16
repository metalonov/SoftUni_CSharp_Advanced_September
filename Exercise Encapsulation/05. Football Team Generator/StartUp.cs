using FootballTeamGenerator.Models;

public class StartUp
{
    static void Main()
    {
        List<Team> teams = new();
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            try
            {
                string[] cmdTokens = command
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                switch (cmdTokens[0])
                {
                    case "Team":
                        Team team = new(cmdTokens[1]);
                        teams.Add(team);
                        break;
                    case "Add":
                        string teamName = cmdTokens[1];
                        Player player = new(cmdTokens[2],
                            int.Parse(cmdTokens[3]),
                            int.Parse(cmdTokens[4]),
                            int.Parse(cmdTokens[5]),
                            int.Parse(cmdTokens[6]),
                            int.Parse(cmdTokens[7]));
                        AddPlayer(player, teamName, teams);
                        break;
                    case "Remove":
                        string playerName = cmdTokens[2];
                        teamName = cmdTokens[1];
                        RemovePlayer(playerName, teamName, teams);
                        break;
                    case "Rating":
                        teamName = cmdTokens[1];
                        PrintRating(teamName, teams);
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

    static void RemovePlayer(string playerName, string teamName, List<Team> teams)
    {
        Team team = teams.FirstOrDefault(t => t.Name == teamName);
        if (team is null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }
        team.RemovePlayer(playerName);
    }

    static void AddPlayer(Player playerName, string teamName, List<Team> teams)
    {
        Team team = teams.FirstOrDefault(t => t.Name == teamName);
        if (team is null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }
        team.AddPlayer(playerName);
    }

    static void PrintRating(string teamName, List<Team> teams)
    {
        Team team = teams.FirstOrDefault(t => t.Name == teamName);
        if (team is null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }
        Console.WriteLine($"{teamName} - {team.Rating:f0}");
    }
}