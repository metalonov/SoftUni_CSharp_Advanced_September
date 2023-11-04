using RawData;

public class StartUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new();

        for (int i = 0; i < n; i++)
        {
            string[] vehicleData = Console.ReadLine()
                .Split()
                .ToArray();
            Car car = new(vehicleData[0],
                int.Parse(vehicleData[1]),
                int.Parse(vehicleData[2]),
                int.Parse(vehicleData[3]),
                vehicleData[4],
                double.Parse(vehicleData[5]), 
                int.Parse(vehicleData[6]),
                double.Parse(vehicleData[7]),
                int.Parse(vehicleData[8]),
                double.Parse(vehicleData[9]),
                int.Parse(vehicleData[10]),
                double.Parse(vehicleData[11]),
                int.Parse(vehicleData[12]));
            cars.Add(car);
        }
        string cargoType = Console.ReadLine();
        List<Car> foundCars = new();
        foreach (var item in cars)
        {
            if ((item.Cargo.Type == cargoType) && (item.Tires.Any(x => x.Pressure < 1)))
            {
                Car car = item;
                foundCars.Add(car);
            }
            else if ((item.Cargo.Type == cargoType) && (item.Engine.Power > 250))
            {
                Car car = item;
                foundCars.Add(car);
            }
        }
        foreach (var item in foundCars)
        {
        Console.WriteLine(item.ToString());
        }
    }
}