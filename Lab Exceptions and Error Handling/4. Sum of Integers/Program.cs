//5 C, 10 D, king C, K C, Q heart, Q H
//9876 string 10 -2147483649 -8 3 4.86555 8
public class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        foreach (var item in input)
        {
            try
            {
                int element = int.Parse(item);
                sum += element;
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name.Contains("FormatException"))
                {
                    Console.WriteLine(FormatException.WrongFormat, item);
                }
                else if (ex.GetType().Name.Contains("OverflowException"))
                {
                    Console.WriteLine(OverflowException.OutOfRange, item);
                }
            }
            Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
        }
        Console.WriteLine($"The total sum of all integers is: {sum}");

    }
}

public class FormatException
{
    public const string WrongFormat = "The element '{0}' is in wrong format!";
}
public class OverflowException
{
    public const string OutOfRange = "The element '{0}' is out of range!";
}