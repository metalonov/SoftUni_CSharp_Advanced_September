using Shapes.Interfaces;

namespace Shapes.Models;

public class Circle : IDrawable
{
    public Circle(int radius)
    {
        Radius = radius;
    }

    public int Radius { get; set; }
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
}
