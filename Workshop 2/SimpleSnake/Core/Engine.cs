using SimpleSnake.Enums;
using SimpleSnake.GameObjects;
using SimpleSnake.GameObjects.Foods;
using SimpleSnake.Utilities;

namespace SimpleSnake.Core;

public class Engine
{
    private const int SleepTime = 150;

    private GameState state;

    private Random random;

    private Food[] foods;
    private Wall boundaries;
    private Snake snake;
    private Point[] pointsOfDirection;

    private Direction currentDirection;
    private Food foodReference;

    public Engine(Wall boundaries, Snake snake)
    {
        CreateDirections();
        random = new Random();

        foods = new Food[]
        {
            new FoodAsterisk(),
            new FoodDollar(),
            new FoodHash()
        };

        this.boundaries = boundaries;
        this.snake = snake;
    }

    public void Start()
    {
        PlaceFoodOnField();
        while (state != GameState.Over)
        {
            if (Console.KeyAvailable)
            {
                currentDirection = GetDirection();
            }

            state = UpdateSnake(pointsOfDirection[(int)currentDirection]);

            if (state == GameState.FoodEaten)
            {
                PlaceFoodOnField();
                state = GameState.Running;
            }

            Thread.Sleep(SleepTime);
        }

        PlatformInteraction.GameOver(boundaries);
    }
    private void CreateDirections()
    {
        pointsOfDirection = new Point[]
        {
        new(1, 0),
        new(-1, 0),
        new(0, 1),
        new(0, -1)
        };
    }

    private GameState UpdateSnake(Point direction)
    {
        GameObject currentSnakehead = snake.Head;
        Point nextHeadPoint = Point.GetNextPoint(direction, currentSnakehead);

        if (snake.CollidesWith(nextHeadPoint))
        {
            return GameState.Over;
        }

        GameObject snakeNewHead = new GameObject(currentSnakehead.DrawSymbol, nextHeadPoint.X, nextHeadPoint.Y);

        if (boundaries.CollidesWith(nextHeadPoint))
        {
            return GameState.Over;
        }

        if (foodReference.CollidesWith(nextHeadPoint))
        {
            snake.Grow(direction, currentSnakehead, foodReference.Points);
            return GameState.FoodEaten;
        }

        snake.Move(snakeNewHead);

        return GameState.Running;
    }

    private Direction GetDirection()
    {
        return PlatformInteraction.GetInput(currentDirection);
    }

    private void PlaceFoodOnField()
    {
        int randomFoodIndex = random.Next(0, foods.Length - 1);
        foodReference = foods[randomFoodIndex];

        do
        {
            foodReference.X = random.Next(2, boundaries.X - 2);
            foodReference.Y = random.Next(2, boundaries.Y - 2);
        }
        while (snake.CollidesWith(foodReference));

        foodReference.Draw();
    }
}

internal enum GameState
{
    Idle,
    Running,
    Start,
    Over,
    FoodEaten
}