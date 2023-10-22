List<int> numbers = Console
    .ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> numbersLargest = numbers.OrderByDescending(x => x)
    .Take(3)
    .ToList();

foreach (var item in numbersLargest)
{
    Console.Write(string.Join(" ", item));
}