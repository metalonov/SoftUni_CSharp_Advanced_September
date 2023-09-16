
int foodQuantity = int.Parse(Console.ReadLine());

int[] orderQuanitity = Console
    .ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> foodOrders
    = new Queue<int>(orderQuanitity);

int biggestOrder = orderQuanitity.Max();

while (foodOrders.Count > 0 && foodQuantity > 0)
{
    int currentOrder = foodOrders.Peek();

    if (foodQuantity - currentOrder >= 0)
    {
        foodQuantity -= currentOrder;
        foodOrders.Dequeue();
    }
    else
    {
        break;
    }
}

    Console.WriteLine(biggestOrder);
if (foodOrders.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {string.Join(" ", foodOrders)}");
}