namespace CarSalesman;

public class StartUp
{
    static void Main()
    {
        int enginesCount = int.Parse(Console.ReadLine());
        List<Engine> engines = new();

        for (int i = 0; i < enginesCount; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = CreateEngine(tokens);
                engines.Add(engine);
        }

        int carCount = int.Parse(Console.ReadLine());
        List<Car> cars = new();

        for (int i = 0; i < carCount; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = CreateCar(tokens, engines);
                cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }

    public static Engine CreateEngine(string[] enginePropeties)
    {
        Engine engine = new Engine(enginePropeties[0], int.Parse(enginePropeties[1]));

        if (enginePropeties.Length > 2)
        {
            int displacement;

            var IsDigit = int.TryParse(enginePropeties[2], out displacement);

            if (IsDigit)
            {
                engine.Displacement = displacement;
            }
            else
            {
                engine.Efficiency = enginePropeties[2];
            }

            if (enginePropeties.Length > 3)
            {
                engine.Efficiency = enginePropeties[3];
            }
        }

        return engine;
    }

    public static Car CreateCar(string[] carPropeties, List<Engine> engines)
    {
        Engine engine = engines.Find(x => x.Model == carPropeties[1]);

        Car car = new Car(carPropeties[0], engine);

        if (carPropeties.Length > 2)
        {
            int weight;

            var isDigit = int.TryParse(carPropeties[2], out weight);

            if (isDigit)
            {
                car.Weight = weight;
            }
            else
            {
                car.Color = carPropeties[2];
            }

            if (carPropeties.Length > 3)
            {
                car.Color = carPropeties[3];
            }
        }

        return car;
    }
}
