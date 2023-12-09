List<int> numbers = Console.ReadLine()
    .Split(",")
    .Select(int.Parse)
    .ToList();

Func<List<int>, int> isOdd = Sum;

Console.WriteLine($"Summing with Func: {isOdd(numbers)}");

Console.WriteLine(numbers.Count);
Console.WriteLine($"Summing with the method: {Sum(numbers)}");
int Sum(List<int> num)
{
    int sum = 0;
    foreach (var item in num)
    {
        sum += item;
    }
    return sum;
}