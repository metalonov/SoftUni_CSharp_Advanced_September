namespace SimpleSnake.GameObjects.Foods;

public class Food : GameObject
{
    public Food(char drawSymbol, int points)
        : base(drawSymbol)
    {
        Points = points;
    }

    public int Points { get; private set; }
}
