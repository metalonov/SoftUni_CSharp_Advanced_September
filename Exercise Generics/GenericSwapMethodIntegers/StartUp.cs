namespace GenericSwapMethodIntegers;
public class StartUp
{
    static void Main()
    {
        List<int> stringList = new();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            int input = int.Parse(Console.ReadLine());
            stringList.Add(input);
        }

        int[] swaps = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        SwapMethod(stringList, swaps[0], swaps[1]);

        foreach (int item in stringList)
        {
            Console.WriteLine($"{item.GetType()}: {item}");
        }
    }
    static void SwapMethod<T>(List<T> list, int a, int b)
    {
        (list[b], list[a]) = (list[a], list[b]);
    }

}