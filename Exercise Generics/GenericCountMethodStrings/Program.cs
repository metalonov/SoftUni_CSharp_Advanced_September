namespace GenericCountMethodSDouble;
public class Program
{
    static void Main()
    {
        Box<string> thebox = new();
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string item = Console.ReadLine();

            thebox.Add(item);
        }
        string itemTocompare = Console.ReadLine();

        Console.WriteLine(thebox.Count(itemTocompare));
    }
}