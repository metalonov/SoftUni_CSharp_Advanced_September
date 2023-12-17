using WildFarm.Core;
using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO;
using WildFarm.IO.Interfaces;

namespace WildFarm;

public class StartUp
{
    static void Main()
    {
        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        IVehicleFactory vehicleFactory = new VehicleFactory();

        IEngine engine = new Engine(reader, writer, vehicleFactory);

        engine.Run();
    }
}

/* regular
Car 15 0.3
Truck 100 0.9
4
Drive Car 9
Drive Car 30
Refuel Car 50
Drive Truck 10
*/

/* extended
Car 30 0.04 70
Truck 100 0.5 300
Bus 40 0.3 150
8
Refuel Car -10
Refuel Truck 0
Refuel Car 10
Refuel Car 300
Drive Bus 10
Refuel Bus 1000
DriveEmpty Bus 100
Refuel Truck 1000
*/