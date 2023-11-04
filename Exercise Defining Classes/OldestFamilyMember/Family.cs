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
        get => this.people;
        set 
        {
            this.people = value;
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
