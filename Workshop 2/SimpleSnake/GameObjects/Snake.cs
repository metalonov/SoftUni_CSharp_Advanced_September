

namespace SimpleSnake.GameObjects;
public class Snake
{
    public const char snakeSymbol = '\u25CF';
    public const char whiteSpaceSymbol = ' ';

    private readonly Queue<GameObject> snakeBody;

    public Snake()
    {
        snakeBody = new Queue<GameObject>();
        GenerateSnakeBody();
    }
    public GameObject Head => snakeBody.Last();

    private void GenerateSnakeBody()
    {
        for (int y = 1; y <= 6; y++)
        {
            var obj = new GameObject(snakeSymbol, 2, y);
            snakeBody.Enqueue(obj);
            obj.Draw();
        }
    }

    public void Move(GameObject newSnakeHead)
    {
        snakeBody.Enqueue(newSnakeHead);

        newSnakeHead.Draw();

        GameObject tail = snakeBody.Dequeue();

        tail = new GameObject(whiteSpaceSymbol, tail.X, tail.Y);

        tail.Draw();
    }

    public bool CollidesWith(Point point)
    {
        return snakeBody
            .Any(s => s.X == point.X && s.Y == point.Y);
    }

    public void Grow(Point direction, Point currentHead, int newPoints)
    {
        Point nextPoint = currentHead;
        for (int i = 0; i < newPoints; i++)
        {
            GameObject obj = new GameObject(snakeSymbol, nextPoint.X, nextPoint.Y);
            obj.Draw();
            snakeBody.Enqueue(obj);
            nextPoint = Point.GetNextPoint(direction, nextPoint);
        }
    }
}
