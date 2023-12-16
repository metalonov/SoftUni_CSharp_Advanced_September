namespace FootballTeamGenerator.Attributes
{
    public abstract class MyValidationAttribute : Attribute
    {

        public abstract bool IsValid(int num);
    }
}
