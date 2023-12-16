namespace FootballTeamGenerator.Exceptions;

public class ExceptionMessages
{
    public const string InvalidDough = "Invalid type of dough.";
    public const string InvalidWeight = $"Dough weight should be in the range [1..200].";
    public const string InvalidPizzaName = $"Pizza name should be between 1 and 15 symbols.";
    public const string TooMuchTopping = $"Number of toppings should be in range [0..10].";
}
