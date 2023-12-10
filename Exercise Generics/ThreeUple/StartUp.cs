using System.Text;

namespace ThreeUple;
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

        StringBuilder sb = new StringBuilder();
        sb.Append(input[3]);
        sb.Append(" ");

        if (input.Length == 5)
        {
            sb.Append(input[4]);
        }

        ThreeUple<string, string, string> nameAddress = new(input[0] + " " + input[1], input[2], sb.ToString().TrimEnd());
        ThreeUple<string, string, bool> nameAgeIsDrunk = new(input2[0], input2[1], input2[2] == "drunk");
        ThreeUple<string, double, string> intDouble = new(input3[0], double.Parse($"{input3[1]:F1}"), input3[2]);

        Console.WriteLine(nameAddress.ToString());
        Console.WriteLine(nameAgeIsDrunk.ToString());
        Console.WriteLine(intDouble.ToString());
    }
}