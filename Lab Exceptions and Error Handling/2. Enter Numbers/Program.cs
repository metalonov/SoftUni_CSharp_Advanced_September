public class Program
{
    static void Main()
    {
        int validNumbers = 10;
        List<int> listofnumbers = new();
        int start = 1;
        int end = 100;

        while (validNumbers > 0)
        {
            try
            {
                string ch = Console.ReadLine();
                int number = IsNumber(ch);
                listofnumbers.Add(ReadNumber(number, start, end));
                start = number;
                validNumbers--;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine(string.Join(", ", listofnumbers));
    }

    static int ReadNumber(int num, int start, int end)
    {
        if (num <= start || num >= end)
        {
            throw new ArgumentException($"Your number is not in range {start} - 100!");
        }
        return num;
    }

    static int IsNumber(string ch)
    {
        if (!int.TryParse(ch, out int result))
        {
            throw new ArgumentException("Invalid Number!");
        }
        return result;
    }
}