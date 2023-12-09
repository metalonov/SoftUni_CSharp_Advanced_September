namespace CarManufacturer;

public class Tire
{
    private double pressure;
    private int year;

    public Tire(int year, double pressure)
    {
        this.Year = year;
        this.Pressure = pressure;
    }

    public double Pressure
    {
        get { return pressure; }
        set { pressure = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }

}
