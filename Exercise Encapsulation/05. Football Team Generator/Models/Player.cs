using FootballTeamGenerator.Exceptions;

namespace FootballTeamGenerator.Models;

public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.InvalidName);
            }
            name = value;
        }
    }

    //[StatsValidation(0, 100)]
    public int Endurance
    {
        get => endurance;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance" + ExceptionMessages.InvalidStats);
            }
            endurance = value;
        }
    }

    //[StatsValidation(0, 100)]
    public int Sprint
    {
        get => sprint;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Sprint" + ExceptionMessages.InvalidStats);
            }
            sprint = value;
        }
    }

    //[StatsValidation(0, 100)]
    public int Dribble
    {
        get => dribble;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Dribble" + ExceptionMessages.InvalidStats);
            }
            dribble = value;
        }
    }

    //[StatsValidation(0, 100)]
    public int Passing
    {
        get => passing;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Passing" + ExceptionMessages.InvalidStats);
            }
            passing = value;
        }
    }

    //[StatsValidation(0, 100)]
    public int Shooting
    {
        get => shooting;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Shooting" + ExceptionMessages.InvalidStats);
            }
            shooting = value;
        }
    }

    public double AverageStats => (endurance + sprint + dribble + passing + shooting) / 5.0;
}
