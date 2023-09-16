List<string> playlist = Console.ReadLine().Split(", ").ToList();


Queue<string> songNames = new Queue<string>(playlist);

while (true)
{
    if (songNames.Count == 0)
    {
        break;
    }

    string[] command = Console.ReadLine()
        .Split()
        .ToArray();

    switch (command[0])
    {
        case "Play":
            songNames.Dequeue();
            break;
        case "Add":
            string songTitleToAdd = string.Join(" ", command.Skip(1));
            if (songNames.Contains(songTitleToAdd))
            {
                Console.WriteLine($"{songTitleToAdd} is already contained!");
                continue;
            }
            songNames.Enqueue(songTitleToAdd);
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songNames));
            break;
    }
}
Console.WriteLine("No more songs!");