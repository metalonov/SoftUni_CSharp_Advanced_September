namespace SimpleSnake.GameObjects;
public class Wall : GameObject
{
    private const char WallSymbol = '\u25A0';

    public Wall(int x, int y)
        : base(WallSymbol, x, y)
    {
    }

    public override void Draw()
    {
        DrawHorizontalLine(0);
        DrawHorizontalLine(Y);

        DrawVerticalLine(0);
        DrawVerticalLine(X - 1);
    }

    private void DrawVerticalLine(int columns)
    {
        for (int col = 0; col < Y; col++)
        {
            GameObject drawPoint = new GameObject(DrawSymbol, columns, col);
            drawPoint.Draw();
        }
    }

    private void DrawHorizontalLine(int rows)
    {
        for (int row = 0; row < X; row++)
        {
            GameObject drawPoint = new GameObject(DrawSymbol, row, rows);
            drawPoint.Draw();
        }
    }
    public override bool CollidesWith(Point point)
    {
        return point.X == X - 1 ||
               point.Y == Y ||
               point.X == 0 ||
               point.Y == 0;
    }
}
