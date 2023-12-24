namespace SimpleSnake.GameObjects.Foods;

public class FoodAsterisk : Food
{
    private const char symbol = '*';
    private const int points = 1;
    public FoodAsterisk() : base(symbol, points)
    {
    }
}
