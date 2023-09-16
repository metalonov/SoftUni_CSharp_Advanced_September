List<string> expr = Console.ReadLine()
    .Split(' ')
    .ToList();

expr.Reverse();

Stack<string> stack = new Stack<string>(expr);

int sum = 0;
char symbol;

sum += int.Parse(stack.Pop());
symbol = char.Parse(stack.Pop());
    if (symbol == '+')
    {
    sum += int.Parse(stack.Pop());
    }
    else
    {
    sum -= int.Parse(stack.Pop());
    }
while (stack.Count > 0)
{
    symbol = char.Parse(stack.Pop());
    if (symbol == '+')
    {
        sum += int.Parse(stack.Pop());
    }
    if (symbol == '-')
    {
        sum -= int.Parse(stack.Pop());
    }
}

Console.WriteLine(sum);