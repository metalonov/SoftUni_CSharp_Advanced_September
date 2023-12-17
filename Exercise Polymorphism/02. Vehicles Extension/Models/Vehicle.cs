using WildFarm.Models.Interfaces;

namespace WildFarm.Models;

public abstract class Vehicle : IVehicle
{
    private double increasedConsumption;
    private double fuelQuantity;
    protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double increasedConsumption)
    {
        TankCapacity = tankCapacity;
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
        this.increasedConsumption = increasedConsumption;
    }

    public double FuelQuantity
    {
        get => fuelQuantity;
        private set
        {
            if (TankCapacity < value)
            {
                fuelQuantity = 0;
            }
            else
            {
                fuelQuantity = value;
            }
        }
    }

    public double FuelConsumption { get; private set; }

    public double TankCapacity { get; private set; }

    public string Drive(double distance, bool isIncreasedConsumption = true)
    {
        double consumption = isIncreasedConsumption
            ? FuelConsumption + increasedConsumption
            : FuelConsumption;

        if (FuelQuantity < distance * consumption)
        {
            throw new ArgumentException($"{this.GetType().Name} needs refueling");
        }
        FuelQuantity -= distance * consumption;
        return $"{this.GetType().Name} travelled {distance} km";
    }
    public virtual void Refuel(double fuelAmount)
    {
        if (fuelAmount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        if (FuelQuantity + fuelAmount > TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
        }
        FuelQuantity += fuelAmount;
    }
    public string DriveEmpty(double distance)
    {
        if (this.FuelQuantity < distance * this.FuelConsumption)
        {
            throw new ArgumentException($"{this.GetType().Name} needs refueling");
        }
        this.FuelQuantity -= distance * FuelConsumption;
        return $"{this.GetType().Name} travelled {distance} km";
    }
    public override string ToString()
        => $"{this.GetType().Name}: {FuelQuantity:F2}";

}
