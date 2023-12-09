namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Car car = new Car();

        car.Make = "VW";
        car.Model = "Golf";
        car.Year = 2006;

        Console.WriteLine($"Make: {car.Make}");
        Console.WriteLine($"Model: {car.Model}");
        Console.WriteLine($"Year: {car.Year}");
    }
}
