using Cars.Interfaces;

namespace Cars.Models;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }

    public string Model { get; private set; }

    public string Color { get; private set; }
    public int Battery { get; private set; }

    public void Start()
    {
        Console.WriteLine("Engine start");
    }

    public void Stop()
    {
        Console.WriteLine("Breaaak!");
    }
    public override string ToString()
    {
        return $"{Color} {GetType().Name} {Model} with {Battery} Batteries";
    }
}
