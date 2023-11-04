using System.Text;

namespace CarSalesman;

public class Car
{
    public Car(string model, Engine engine)
    {
        CarModel = model;
        Engine = engine;
    }

    public string CarModel { get; set; }
    public Engine Engine { get; set; }
    public int Weight { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        string weight = Weight == 0 ? "n/a" : Weight.ToString();
        string color = Color ?? "n/a";
        string displacement = Engine.Displacement == 0 ? "n/a" : Engine.Displacement.ToString();
        string efficiency = Engine.Efficiency ?? "n/a";

        StringBuilder sb = new();
        sb.AppendLine($"{CarModel}:");
        sb.AppendLine($"  {Engine.Model}:");
        sb.AppendLine($"    Power: {Engine.Power}");
        sb.AppendLine($"    Displacement: {displacement}");
        sb.AppendLine($"    Efficiency: {efficiency}");
        sb.AppendLine($"  Weight: {weight}");
        sb.AppendLine($"  Color: {color}");
        return sb.ToString().Trim();
    }
}