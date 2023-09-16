int[] parameters = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int queueTimes = parameters[0];
int dequeueTimes = parameters[1];
int peek = parameters[2];

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>();

foreach (var item in numbers)
{
    queue.Enqueue(item);
}

while (queue.Count > 0 && dequeueTimes > 0)
{
    queue.Dequeue();
    dequeueTimes--;
}

if (queue.Contains(peek))
{
    Console.WriteLine("true");
}
else if (queue.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(queue.Min());
}