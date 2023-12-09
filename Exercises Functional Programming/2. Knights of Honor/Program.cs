
Action<string, string[]> print = (title, names) =>
{
    foreach (string item in names)
    {
        Console.WriteLine($"{title} {item}");
    }
};

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

print("Sir", input);