using System.Threading.Channels;

Func<int, int, List<int>> generange = (start, end) =>
{
List<int> range = new List<int>();

    while (start <= end)
    {
        range.Add(start);
        start++;
    }

return range;
};

Func<string, int, bool> evenOddMatch = (condition, number) =>
{
    if (condition == "even")
    {
        return number % 2 == 0;
    }
    else
    {
        return number % 2 != 0;
    }
};


int[] rangeTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = Console.ReadLine();


List<int> numbers = generange(rangeTokens[0], rangeTokens[1]);

foreach (int number in numbers)
{
    if (evenOddMatch(command, number))
    {
        Console.Write($"{number} ");
    }
}