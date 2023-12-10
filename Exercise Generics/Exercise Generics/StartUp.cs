namespace Exercise_Generics;
public class StartUp
{
    static void Main()
    {
        Box<string> boxes = new();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            boxes.Add(Console.ReadLine());
        }

        Console.WriteLine(boxes.ToString().TrimEnd());
    }
}