namespace Shapes;

public class Rectangle : Shape
{
    private int height;
    private int width;

    public int Width
    {
        get { return width; }
        private set { width = value; }
    }


    public int Height
    {
        get { return height; }
        private set { height = value; }
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }


    public void Draw()
    {
        DrawLine(Width, '*', '*');
        for (int i = 1; i < Height - 1; ++i)
        {
            DrawLine(Width, '*', ' ');
        }
        DrawLine(Width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < width - 1; ++i)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }
    public override double CalculateArea()
    {
        return width * width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (width + width);
    }
}
