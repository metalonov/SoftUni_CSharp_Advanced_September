namespace GenericCountMethodSDouble;
public class Program
{
    static void Main()
    {
        Box<double> thebox = new();
        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            double item = double.Parse(Console.ReadLine());

            thebox.Add(item);
        }
        double itemTocompare = double.Parse(Console.ReadLine());

        Console.WriteLine(thebox.Count(itemTocompare));
    }
}