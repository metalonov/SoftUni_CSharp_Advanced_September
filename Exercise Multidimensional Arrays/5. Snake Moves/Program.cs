int[] size = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => int.Parse(n)) //парсване с фукнция
        .ToArray();


string snake = Console.ReadLine();

int rows = size[0];
int cols = size[1];

char[,] matrix = new char[size[0], size[1]];
int snakeIndex = 0;
int stringLength = snake.Length;

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col <= matrix.GetLength(0); col++)
    {
        matrix[row, col] = snake[snakeIndex];
        snakeIndex = SnakeLetterCount(snakeIndex, stringLength);
    }
    if (row == rows-1)
    {
        break;
    }
    else
    {
        row++;
    }
    for (int reverseCol = matrix.GetLength(0); reverseCol >= 0; reverseCol--)
    {
        matrix[row, reverseCol] = snake[snakeIndex];
        snakeIndex = SnakeLetterCount(snakeIndex, stringLength);
    }

}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}

static int SnakeLetterCount (int input, int rangeInput)
{
    if (input >= rangeInput - 1)
    {
        input = 0;
    }
    else
    {
        input++;
    }
    return input;
}