namespace ExplicitInterfaces.Models.Interfaces;

public interface IResident
{
    string Name { get; }
    string Country { get; }

    public string GetName()
    {
        return "Mr/Ms/Mrs ";
    }
}
