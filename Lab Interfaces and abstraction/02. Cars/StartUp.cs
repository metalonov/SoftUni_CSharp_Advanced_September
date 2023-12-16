using Cars.Interfaces;
using Cars.Models;

public class StartUp
{
    static void Main()
    {
        ICar seat = new Seat("Leon", "Grey");
        ICar tesla = new Tesla("Model 3", "Red", 2);

        Console.WriteLine(seat.ToString());
        seat.Start();
        seat.Stop();
        Console.WriteLine(tesla.ToString());
        tesla.Start();
        tesla.Stop();
    }
}