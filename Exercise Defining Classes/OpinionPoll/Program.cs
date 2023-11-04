namespace OpinionPoll;

public class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        List<Person> people = new();

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Person person = new(input[0], int.Parse(input[1]));
            people.Add(person);
        }

        var sortedPeople = people.OrderBy(x => x.Name);

        foreach (var person in sortedPeople)
        {
            if (person.Age > 30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
//Using the Person class, write a program that reads from the console N lines
//of personal information and then prints all people, whose age is more than 30 years,
//sorted in alphabetical order.