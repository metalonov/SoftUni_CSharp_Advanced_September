int[] parameters = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int pushTimes = parameters[0];
int popTimes = parameters[1];
int peek = parameters[2];

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>(numbers.Take(pushTimes));


while (stack.Count > 0 && popTimes > 0)
{
    stack.Pop();
    popTimes--;
}

if (stack.Contains(peek))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(stack.Min());
}