using WildFarm.Models.Interfaces;

namespace WildFarm.Factories.Interfaces;

public interface IVehicleFactory
{
    IVehicle Create(string type, double fuelQuantity, double fuelConsumption, double tankCapacity);
}
