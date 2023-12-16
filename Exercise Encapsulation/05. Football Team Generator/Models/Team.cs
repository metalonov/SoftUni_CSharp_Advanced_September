using FootballTeamGenerator.Exceptions;

namespace FootballTeamGenerator.Models;

public class Team
{
    private string name;
    private double rating;
    private List<Player> roster;

    public Team(string name)
    {
        Name = name;
        Rating = rating;

        roster = new();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Rating
    {
        get
        {
            if (roster.Any())
            {
                return roster.Average(x => x.AverageStats);
            }
            return 0;
        }
        set
        {
            rating = value;
        }
    }

    public void AddPlayer(Player player)
        => roster.Add(player);
    public void RemovePlayer(string playerName)
    {
        Player player = roster.FirstOrDefault(p => p.Name == playerName);
        if (player == null)
        {
            throw new ArgumentException(string.Format(ExceptionMessages.InvalidTeam, playerName, Name));
        }
        roster.Remove(player);
    }
}
