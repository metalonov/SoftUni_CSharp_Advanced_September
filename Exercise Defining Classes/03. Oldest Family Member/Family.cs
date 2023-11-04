namespace DefiningClasses;

public class Family
{
    private List<Person> people;
    public Family()
    {
        people = new List<Person>();
    }

    public List<Person> People 
    { 
        get => people;
        set 
        {
            this.People = value;
        }
    }
    public void AddMember(Person person)
    {
        this.People.Add(person);
    }
    public void GetOldestMember()
    {
        Console.WriteLine(People.MaxBy(p => p.Age));
    }
}
