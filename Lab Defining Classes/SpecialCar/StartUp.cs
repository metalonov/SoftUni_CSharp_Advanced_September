using CarManufacturer;

public class StartUp
{
    static void Main()
    {
        List<Engine> engines = new List<Engine>();
        List<Tire> tires = new List<Tire>();
        List<Car> cars = new List<Car>();

        string tirePrompts;

        while ((tirePrompts = Console.ReadLine()) != "No more tires")
        {
            string[] argums = tirePrompts
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int year1 = int.Parse(argums[0]);
            double pressure1 = double.Parse(argums[1]);
            int year2 = int.Parse(argums[2]);
            double pressure2 = double.Parse(argums[3]);
            int year3 = int.Parse(argums[4]);
            double pressure3 = double.Parse(argums[5]);
            int year4 = int.Parse(argums[6]);
            double pressure4 = double.Parse(argums[7]);
            Tire tire = new Tire(year1, pressure1, year2, pressure2, year3, pressure3, year4, pressure4);
            tires.Add(tire);
        }
        string enginePrompts;
        while ((enginePrompts = Console.ReadLine()) != "Engines done")
        {
            string[] argums = enginePrompts
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int horsePower = int.Parse(argums[0]);
            double capacity = double.Parse(argums[1]);
            Engine engine = new Engine(horsePower, capacity);
            engines.Add(engine);
        }
        string showSpecialPrompts;
        while ((showSpecialPrompts = Console.ReadLine()) != "Show special")
        {
            string[] argums = showSpecialPrompts
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string make = argums[0];
            string model = argums[1];
            int year = int.Parse(argums[2]);
            double fuelQuantity = double.Parse(argums[3]);
            double fuelConsumption = double.Parse(argums[4]);
            Engine engine = engines[int.Parse(argums[5])];
            Tire tire = tires[int.Parse(argums[6])];
            Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);
            cars.Add(car);
        }

        foreach (var car in cars)
        {
            if (car.Year >= 2017 && car.Engine.HorsePower >= 330 &&
                (car.Tires.Pressure1 + car.Tires.Pressure2 + car.Tires.Pressure3 + car.Tires.Pressure4 < 10.0
                && car.Tires.Pressure1 + car.Tires.Pressure2 + car.Tires.Pressure3 + car.Tires.Pressure4 > 9.0))
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }

    }
}