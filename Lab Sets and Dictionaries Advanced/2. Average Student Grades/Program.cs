int inputsCounter = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();

for (int i = 0; i < inputsCounter; i++)
{
    string[] line = Console
        .ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string name = line[0];
    decimal score = decimal.Parse(line[1]);
    if (!dict.ContainsKey(name))
    {
        dict.Add(name, new List<decimal>());
    }
    dict[name].Add(score);
}

foreach (KeyValuePair<string, List<decimal>> item in dict)
{
    Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value):f2} (avg: {item.Value.Average():f2})");
}