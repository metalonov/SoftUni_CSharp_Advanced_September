public class Program
{
    static void Main()
    {
        try
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                throw new ArgumentException("Invalid number.");
            }
            Console.WriteLine(Math.Sqrt(num));
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye.");
        }
    }
}