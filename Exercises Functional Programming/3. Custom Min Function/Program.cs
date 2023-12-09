Func<HashSet<int>, int> min = numbers =>
{
    int min = int.MaxValue;

    foreach (int item in numbers)
    {
        if (item < min)
        {
            min = item;
        }

    }
    return min;
};

HashSet<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

Console.WriteLine(min(numbers));