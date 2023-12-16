using FootballTeamGenerator.Exceptions;

namespace FootballTeamGenerator.Attributes;

public class StatsValidationAttribute : MyValidationAttribute
{
    int minValue;
    int maxValue;

    public StatsValidationAttribute(int minValue, int maxValue)
    {
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    public override bool IsValid(int num)
    {
        if (num >= minValue && num < maxValue)
        {
            throw new ArgumentException(num + ExceptionMessages.InvalidStats);
        }
        return false;
    }
}
