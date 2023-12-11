
namespace WorkshopSKaskata.GameObjects;

internal class Wall : GameObject
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

        DrawVerticalLine(X - 1);
        DrawVerticalLine(0);
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
}
