namespace WildFarm.Models.Interfaces;

public interface IVehicle
{
    double FuelQuantity { get; }
    double FuelConsumption { get; }
    double TankCapacity { get; }

    public string Drive(double distance, bool isIncreasedConsumption = true);
    string DriveEmpty(double distance);
    void Refuel(double fuelAmount);

}
