Queue<string> people = new Queue<string>(Console.ReadLine().Split());

int tossCount = int.Parse(Console.ReadLine());
int tosses=0;


while (people.Count > 1)
{
    tosses++;
    string childWithPotato = people.Dequeue();

    if (tosses == tossCount)
    {
        tosses = 0;
        Console.WriteLine($"Removed {childWithPotato}");
    }
    else
    {
        people.Enqueue(childWithPotato);
    }
}
Console.WriteLine($"Last is {people.Dequeue()}");