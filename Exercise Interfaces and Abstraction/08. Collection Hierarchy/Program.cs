using CollectionHierarchy.Models;

internal class Program
{
    static void Main()
    {

        List<string> input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        int removeTimes = int.Parse(Console.ReadLine());

        AddCollection list1 = new AddCollection();
        AddRemoveCollection list2 = new AddRemoveCollection();
        MyList myList = new MyList();


        for (int j = 0; j < input.Count - 1; j++)
        {
            Console.Write($"{list1.Add(input[j])}");
            Console.Write(" ");
        }
        Console.Write($"{list1.Add(input[input.Count - 1])}");
        Console.WriteLine();
        for (int j = 0; j < input.Count - 1; j++)
        {
            Console.Write($"{list2.Add(input[j])} ");
        }
        Console.Write($"{list2.Add(input[input.Count - 1])}");
        Console.WriteLine();
        for (int i = 0; i < input.Count - 1; i++)
        {
            Console.Write($"{myList.Add(input[i])} ");
        }
        Console.Write($"{myList.Add(input[input.Count - 1])}");
        Console.WriteLine();
        for (int i = 0; i < removeTimes; i++)
        {
            Console.Write($"{list2.Remove()} ");
        }
        Console.WriteLine();
        for (int i = 0; i < removeTimes; i++)
        {
            Console.Write($"{myList.Remove()} ");
        }
    }
}