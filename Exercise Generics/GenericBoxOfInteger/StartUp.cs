namespace GenericBoxOfInteger;
public class StartUp
{
    static void Main()
    {
        Box<int> boxes = new();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            boxes.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine(boxes.ToString().TrimEnd());
    }
}