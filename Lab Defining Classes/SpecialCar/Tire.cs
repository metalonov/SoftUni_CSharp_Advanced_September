namespace CarManufacturer;

public class Tire
{
    private double pressure1;
    private int year1;
    private double pressure2;
    private int year2;
    private double pressure3;
    private int year3;
    private double pressure4;
    private int year4;

    public Tire(int year1, double pressure1, int year2, double pressure2, int year3, double pressure3, int year4, double pressure4)
    {
        this.Year1 = year1;
        this.Pressure1 = pressure1;
        this.Year2 = year2;
        this.Pressure2 = pressure2;
        this.Year3 = year3;
        this.Pressure3 = pressure3;
        this.Year4 = year4;
        this.Pressure4 = pressure4;
    }

    public double Pressure1
    {
        get { return pressure1; }
        set { pressure1 = value; }
    }
    public int Year1
    {
        get { return year1; }
        set { year1 = value; }
    }

    public double Pressure2
    {
        get { return pressure2; }
        set { pressure2 = value; }
    }
    public int Year2
    {
        get { return year2; }
        set { year2 = value; }
    }

    public double Pressure3
    {
        get { return pressure3; }
        set { pressure3 = value; }
    }
    public int Year3
    {
        get { return year3; }
        set { year3 = value; }
    }

    public double Pressure4
    {
        get { return pressure4; }
        set { pressure4 = value; }
    }
    public int Year4
    {
        get { return year4; }
        set { year4 = value; }
    }
}
