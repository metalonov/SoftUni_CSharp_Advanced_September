using System.Text;

namespace CarManufacturer;

public class Car
{
    private string make;
    private int year;
    private string model;
    private double fuelQuantity;
    private double fuelConsumption;
    private Engine engine;
    private Tire tires;

    public Car()
    {
        Make = "VW";
        Model = "Golf";
        Year = 2025;
        FuelQuantity = 200;
        FuelConsumption = 10;
    }

    public Car(string make, string model, int year) : this()
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
    {
        this.FuelConsumption = fuelConsumption;
        this.FuelQuantity = fuelQuantity;
    }
    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire tires)
        : this(make, model, year, fuelQuantity, fuelConsumption)
    {
        this.Engine = engine;
        this.Tires = tires;
    }
    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }
    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public Tire Tires
    {
        get { return tires; }
        set { tires = value; }
    }
    public void Drive(double distance)
    {
        if (FuelQuantity - FuelConsumption * distance / 100 < 0)
        {
            Console.WriteLine($"Not enough fuel to perform this trip!");
        }
        else
        {
            FuelQuantity -= FuelConsumption * distance / 100;
        }
    }

    public string WhoAmI()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Make: {this.Make}");
        sb.AppendLine($"Model: {this.Model}");
        sb.AppendLine($"Year: {this.Year}");
        sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
        sb.AppendLine($"FuelQuantity: {this.FuelQuantity:F1}");

        return sb.ToString().TrimEnd();
    }
}
