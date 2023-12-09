
Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

List<string> sentence = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(checker)
    .ToList();


foreach (string item in sentence)
{

        Console.WriteLine(item);

}