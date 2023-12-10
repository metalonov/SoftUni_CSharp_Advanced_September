namespace GenericSwapMethodStrings;
public class StartUp
{
    static void Main()
    {
        List<string> stringList = new();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();
            stringList.Add(input);
        }

        int[] swaps = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        SwapMethod(stringList, swaps[0], swaps[1]);

        foreach (string item in stringList)
        {
            Console.WriteLine($"{item.GetType()}: {item}");
        }

    }
    static void SwapMethod<T>(List<T> list, int a, int b)
    {
        (list[a], list[b]) = (list[b], list[a]);
    }
}