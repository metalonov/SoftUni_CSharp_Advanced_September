namespace ClassBoxData.Models;

public class Box
{

    private double _length;
    private double _width;
    private double _height;
    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double Length
    {
        get => _length;
        init
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            _length = value;
        }
    }
    public double Width
    {
        get => _width;
        init
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            _width = value;
        }
    }
    public double Height
    {
        get => _height;
        init
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            _height = value;
        }
    }

    public double Volume(double length, double width, double height)
        => length * width * height;
    public double SurfaceArea(double length, double width, double height)
        => 2 * (length * width) + LateralSurfaceArea(length, width, height);
    public double LateralSurfaceArea(double length, double width, double height)
        => 2 * (length * height) + 2 * (width * height);

}