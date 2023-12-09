List<double> prices = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToList();

Func<double, double> vat = n => n * 1.2;


foreach (double item in prices)
{
    Console.WriteLine($"{vat(item):f2}");
}

