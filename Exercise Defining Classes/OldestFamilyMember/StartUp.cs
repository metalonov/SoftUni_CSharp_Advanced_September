namespace DefiningClasses;
using System;

public class StartUp
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Family family = new();

        for (int i = 0; i < num; i++)
        {
            string[] member = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = member[0];
            int age = int.Parse(member[1]);
            Person person = new(name, age);
            family.AddMember(person);
        }
        
        family.GetOldestMember();
    }
}
