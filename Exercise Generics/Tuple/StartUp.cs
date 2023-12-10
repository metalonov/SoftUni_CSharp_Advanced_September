namespace Tuple;

public class StartUp
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string[] input2 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string[] input3 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        CustomTuple<string, string> nameAddress = new(input[0] + " " + input[1], input[2]);
        CustomTuple<string, int> nameLiters = new(input2[0], int.Parse(input2[1]));
        CustomTuple<int, double> intDouble = new(int.Parse(input3[0]), double.Parse(input3[1]));

        Console.WriteLine(nameAddress.ToString());
        Console.WriteLine(nameLiters.ToString());
        Console.WriteLine(intDouble.ToString());
    }
}