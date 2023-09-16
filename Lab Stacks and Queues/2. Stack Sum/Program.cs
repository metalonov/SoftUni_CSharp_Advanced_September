using System.Threading.Channels;

Stack<int> stack = new Stack<int>(Console
    .ReadLine()
    .Split()
    .Select(int.Parse));

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] splitted = command.Split(' ');
    if (command.Contains("add"))
    {
        int num1 = int.Parse(splitted[1]);
        int num2 = int.Parse(splitted[2]);

        stack.Push(num1);
        stack.Push(num2);
    }
    else if (command.Contains("remove"))
    {
        int iterations = int.Parse(splitted[1]);
        if (stack.Count > iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
            stack.Pop();
            }
        }
    }
    command = Console.ReadLine().ToLower();

}
int sum = 0;

while (stack.Count > 0)
{
    sum += stack.Pop();
}
Console.WriteLine($"Sum: {sum}");