namespace Shapes;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius
    {
        get { return radius; }
        private set { radius = value; }
    }


    public void Draw()
    {
        double rin = this.Radius - 0.4;
        double rout = this.Radius + 0.4;
        for (double y = Radius; y >= -Radius; --y)
        {
            for (double x = -Radius; x < rout; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= rin * rin && value <= rout * rout)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
