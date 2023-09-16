
List<int> nums = new List<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList());

Queue<int> queue = new Queue<int>(nums);

while (queue.Count > 0)
{
    int num = queue.Dequeue();
    if (num % 2 == 0 && num != 0 && num > 0)
    {
        Console.Write(num);
        if (queue.Count >= 1)
        {
        Console.Write(", ");
        }
    }
}