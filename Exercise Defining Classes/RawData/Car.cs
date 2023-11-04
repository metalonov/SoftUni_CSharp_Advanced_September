namespace RawData;

public class Car
{
    public Car(string model, int speed, int power, int weight, string type, 
        double pressure1, int age1, double pressure2, int age2, double pressure3, int age3, double pressure4, int age4)
    {
        Model = model;
        Engine = new(speed, power);
        Cargo = new(weight, type);
        Tires = new Tires[4];
        Tires[0] = new(pressure1, age1);
        Tires[1] = new(pressure2, age2);
        Tires[2] = new(pressure3, age3);
        Tires[3] = new(pressure4, age4);
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public Tires[] Tires { get; set; }


    public override string ToString()
    {
        return $"{Model}";
    }
}
