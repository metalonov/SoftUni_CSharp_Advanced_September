Stack<int> stack = new Stack<int>();

int queryTimes = int.Parse(Console.ReadLine());

for (int i = 0; i < queryTimes; i++)
{
    int[] commands = Console
        .ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    if (commands[0] == 1)
    {
        stack.Push(commands[1]);
    }
    else if (commands[0] == 2 && stack.Count > 0)
    {
        stack.Pop();
    }
    else if (commands[0] == 3 && stack.Count > 0)
    {
        Console.WriteLine(stack.Max());
    }
    else if (commands[0] == 4 && stack.Count > 0)
    {
        Console.WriteLine(stack.Min());
    }
}
if (stack.Count > 0)
{

Console.WriteLine(string.Join(", ", stack));
}