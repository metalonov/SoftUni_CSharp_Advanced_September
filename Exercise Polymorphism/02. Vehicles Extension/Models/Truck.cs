namespace WildFarm.Models;

public class Truck : Vehicle
{
    private const double IncreasedConsumption = 1.6;
    public Truck(
        double fuelQuantity,
        double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity, IncreasedConsumption)
    {
    }

    public override void Refuel(double fuelAmount)
    {
        if (fuelAmount <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }
        else if (FuelQuantity + fuelAmount > TankCapacity)
        {
            Console.WriteLine($"Cannot fit {fuelAmount} fuel in the tank");
        }
        else
        {
            base.Refuel(fuelAmount * 0.95);
        }
    }
}
