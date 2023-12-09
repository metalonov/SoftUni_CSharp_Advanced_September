using System.Text;

namespace CarManufacturer;

public class Car
{
    private string make;
    private int year;
    private string model;
    private double fuelQuantity;
    private double fuelConsumption;

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

    public void Drive(double distance)
    {
        if (FuelQuantity - FuelConsumption * distance < 0)
        {
            Console.WriteLine($"Not enough fuel to perform this trip!");
        }
        else
        {
            FuelQuantity -= FuelConsumption * distance;
        }
    }

    public string WhoAmI()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Make: {this.Make}");
        sb.AppendLine($"Model: {this.Model}");
        sb.AppendLine($"Year: {this.Year}");
        sb.AppendLine($"Fuel: {this.FuelQuantity:F2}");

        return sb.ToString().TrimEnd();
    }
}
