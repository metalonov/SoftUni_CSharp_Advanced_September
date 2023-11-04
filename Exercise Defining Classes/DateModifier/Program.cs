namespace DateModifier;
using System;
public class StartUp
{
    static void Main()
    {
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();

        Console.WriteLine(DateModifier.GetDifferenceInDays(startDate, endDate));
    }
}