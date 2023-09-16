
List<int> clothes = Console
    .ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

clothes.Reverse();

int rackCapacity = int.Parse(Console.ReadLine());
int numberOfRacks = 0;

Stack<int> stack = new Stack<int>(clothes);

int rackCurrentCapacity = 0;

while (stack.Count > 0)
{
    int num = stack.Peek();
    if (rackCurrentCapacity + num <= rackCapacity)
    {
        rackCurrentCapacity += stack.Pop();
    }
    if (stack.Count == 0)
    {
        numberOfRacks++;
        rackCurrentCapacity = 0;
        break;
    }
    num = stack.Peek();
    if (rackCurrentCapacity + num > rackCapacity)
    {
        numberOfRacks++;
        rackCurrentCapacity = 0;
    }
}

Console.WriteLine(numberOfRacks);