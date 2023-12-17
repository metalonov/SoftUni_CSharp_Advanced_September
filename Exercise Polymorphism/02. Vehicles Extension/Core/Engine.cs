using WildFarm.Core.Interfaces;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core;
public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWriter writer;
    private readonly IVehicleFactory vehicleFactory;

    private readonly ICollection<IVehicle> vehicles;
    public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
    {
        this.reader = reader;
        this.writer = writer;
        this.vehicleFactory = vehicleFactory;
        vehicles = new List<IVehicle>();
    }

    public void Run()
    {

        vehicles.Add(VehicleSpawn()); //for car
        vehicles.Add(VehicleSpawn()); //for truck
        vehicles.Add(VehicleSpawn()); //for bus


        int n = int.Parse(reader.ReadLine());
        for (int i = 0; i < n; i++)
        {
            try
            {
                ProcessCommand();
            }
            catch (ArgumentException ex)
            {
                writer.WriteLine(ex.Message);
            }
        }

        foreach (IVehicle vehicle in vehicles)
        {
            writer.WriteLine(vehicle.ToString());
        }
    }

    private IVehicle VehicleSpawn()
    {
        string[] input = reader.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        return vehicleFactory.Create(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
    }

    public void ProcessCommand()
    {
        string[] tokens = reader.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        string action = tokens[0];
        IVehicle typeOfVehicle = vehicles.FirstOrDefault(v => v.GetType().Name == tokens[1]);
        if (typeOfVehicle == null)
        {
            throw new ArgumentException("Invalid vehicle type");
        }
        if (action == "Drive")
        {
            writer.WriteLine(typeOfVehicle.Drive(double.Parse(tokens[2])).ToString());
        }
        else if (action == "Refuel")
        {
            typeOfVehicle.Refuel(double.Parse(tokens[2]));
        }
        else if (action == "DriveEmpty")
        {
            writer.WriteLine(typeOfVehicle.DriveEmpty(double.Parse(tokens[2])).ToString());
        }
    }
}

