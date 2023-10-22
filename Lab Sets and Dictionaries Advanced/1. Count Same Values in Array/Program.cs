
using System.Runtime.InteropServices;

List<double> input = Console
    .ReadLine()
    .Split()
    .Select(double.Parse)
    .ToList();

Dictionary<double, int> dict = new Dictionary<double, int>();

foreach (double item in input)
{
    if (!dict.ContainsKey(item))
    {
        dict.Add(item, 1);

    }
    else
    {
        dict[item]++;
    }
}

foreach (KeyValuePair<double, int> item in dict)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}