Func<string, List<int>, List<int>> calculate = (command, numbers) =>
{
    List<int> result = new();
    foreach (int number in result)
    {
        switch (command)
        {
            case "add":
                result.Add(number + 1);
                break;
            case "multiply":
                result.Add(number * 2);
                break;
            case "subtract":
                result.Add(number - 1);
                break;
        }

    }
    return result;
};

List<int> numbersList = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

