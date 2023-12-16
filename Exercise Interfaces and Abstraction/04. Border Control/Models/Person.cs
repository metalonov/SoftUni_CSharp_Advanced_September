using BorderControl.Models.Interfaces;

namespace BorderControl.Models;

public class Person : IIdentifiable
{
    private string name;
    private int age;
    private string id;

    public Person(string name, int age, string id)
    {
        Name = name;
        Age = age;
        Id = id;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

}
