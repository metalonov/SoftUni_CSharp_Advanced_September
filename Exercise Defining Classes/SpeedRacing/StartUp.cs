namespace SpeedRacing;
using System;

public class StartUp
{

    static void Main()
    {
        int numberOfCars = int.Parse(Console.ReadLine());

        List<Car> cars = new();

        for (int i = 0; i < numberOfCars; i++)
        {
        string[] inputs = Console.ReadLine()
            .Split();
        string brand = inputs[0];
        int fuelAmount = int.Parse(inputs[1]);
        double consumption = double.Parse(inputs[2]);
        Car car = new Car(brand, fuelAmount, consumption);
            cars.Add(car);
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = cars.FirstOrDefault(x => x.Model == tokens[1]);
            car.Drive(car, int.Parse(tokens[2]));
        }
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
