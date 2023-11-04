namespace DefiningClasses;
using System;
public class StartUp
{
    static void Main()
    {
        Person person = new();
        Person person2 = new(43);
        Person person3 = new("Jose", 43);

        Console.WriteLine($"{person.Name}, {person.Age}");
        Console.WriteLine($"{person2.Name}, {person2.Age}");
        Console.WriteLine($"{person3.Name}, {person3.Age}");
    }
}
