using ExplicitInterfaces.Models.Interfaces;

namespace ExplicitInterfaces.Models;

public class Person : IPerson
{
    private string name;

    private int age;

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


}
