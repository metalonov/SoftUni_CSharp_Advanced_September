Stack<int> worms = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
Queue<int> holes = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int matchCounter = 0;
int wormsCount = worms.Count;

while (holes.Count > 0 && worms.Count > 0)
{
    int currentWorm = worms.Peek();
    int currentHole = holes.Peek();

    if (currentWorm <= 0)
    {
        worms.Pop();
    }
    else if (currentWorm == currentHole)
    {
        holes.Dequeue();
        worms.Pop();
        matchCounter++;
    }
    else
    {
        holes.Dequeue();
        currentWorm -= 3;
        worms.Pop();
        worms.Push(currentWorm);
    }
}

if (matchCounter == 0)
{
    Console.WriteLine("There are no matches.");
}
else
{
    Console.WriteLine($"Matches: {matchCounter}");
}

if (wormsCount == matchCounter && holes.Count == 0)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (worms.Count == 0 && holes.Count > 0)
{
    Console.WriteLine("Worms left: none");
}
else // (worms.Count > 0)
{
    Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
}

if (holes.Count == 0)
{
    Console.WriteLine("Holes left: none");
}
else //(holes.Count > 0)
{
    Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
}
