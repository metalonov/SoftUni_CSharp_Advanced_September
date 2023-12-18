public class Program
{
    static void Main()
    {
        List<int> array = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int exceptionsCounter = 3;

        while (exceptionsCounter > 0)
        {
            string[] commandArgs = Console.ReadLine()
                .Split();
            try
            {
                if (commandArgs[0] == "Replace")
                {
                    int index = int.Parse(commandArgs[1]);
                    int element = int.Parse(commandArgs[2]);
                    Replace(index, element, array);
                }
                else if (commandArgs[0] == "Show")
                {
                    int elementToShow = int.Parse(commandArgs[1]);
                    Console.WriteLine(Show(array, elementToShow));
                }
                else if (commandArgs[0] == "Print")
                {
                    int start = int.Parse(commandArgs[1]);
                    int end = int.Parse(commandArgs[2]);
                    List<int> printArray = array.GetRange(start, end);
                    Console.WriteLine(string.Join(", ", printArray));
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name.Contains("Argument"))
                {
                    exceptionsCounter--;
                    Console.WriteLine(OutOfRangeException.IndexDoesNotExist);
                }
                else if (ex.GetType().Name is "FormatException")
                {
                    exceptionsCounter--;
                    Console.WriteLine(InvalidType.TypeIsInvalid);
                }
            }
        }
        Console.WriteLine(string.Join(", ", array));
    }

    static void Replace(int index, int element, List<int> list)
    {
        list.RemoveAt(index);
        list.Insert(index, element);
    }
    static int Show(List<int> list, int index)
    {
        return list[index];
    }

}
public class OutOfRangeException
{
    public const string IndexDoesNotExist = "The index does not exist!";
}
public class InvalidType
{
    public const string TypeIsInvalid = "The variable is not in the correct format!";
}

/*
1 2 3 4 5
Replace 1 9
Replace 6 3
Show 3
Show peter
Show 6
*/
/*
1 2 3 4 5
Replace 3 9
Print 1 4
Print -3 12
Print 1 5
Show 3
Show 12.3
*/