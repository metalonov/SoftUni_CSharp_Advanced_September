using System.Data;
using System.Threading.Tasks.Dataflow;

int size = int.Parse(Console.ReadLine());

int[,] field = new int[size, size];
int sum = 0;
int aliveCells = 0;

for (int row = 0; row < size; row++)
{
    int[] cells = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)
    {
        field[row, col] = cells[col];
    }
}

string[] bombCoordinates = Console.ReadLine()
    .Split()
    .ToArray();



for (int coordRow = 0; coordRow < bombCoordinates.Length; coordRow++)//iterates by coordinates amount
{
    int[] coordinates = bombCoordinates[coordRow]
        .Split(",", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    int bombPower = field[coordinates[0], coordinates[1]];
    if (OutOfRangeCheck(coordinates[0] - 1, coordinates[1] - 1, size) 
        && CellNotExploded(field[coordinates[0] - 1, coordinates[1] - 1]))
    {
        field[coordinates[0] - 1, coordinates[1] - 1] -= bombPower; //up left
    }
    if (OutOfRangeCheck(coordinates[0] - 1, coordinates[1], size)
        && CellNotExploded(field[coordinates[0] - 1, coordinates[1]]))
    {
        field[coordinates[0] - 1, coordinates[1]] -= bombPower; //up mid
    }
    if (OutOfRangeCheck(coordinates[0] - 1, coordinates[1] + 1, size)
        && CellNotExploded(field[coordinates[0] - 1, coordinates[1] + 1]))
    {
        field[coordinates[0] - 1, coordinates[1] + 1] -= bombPower; //up right
    }
    if (OutOfRangeCheck(coordinates[0], coordinates[1] - 1, size)
        && CellNotExploded(field[coordinates[0], coordinates[1] - 1]))
    {
        field[coordinates[0], coordinates[1] - 1] -= bombPower; //left
    }
    if (OutOfRangeCheck(coordinates[0], coordinates[1], size)
        && CellNotExploded(field[coordinates[0], coordinates[1]]))
    {
        field[coordinates[0], coordinates[1]] -= bombPower; //center
    }
    if (OutOfRangeCheck(coordinates[0] + 1, coordinates[1] + 1, size)
        && CellNotExploded(field[coordinates[0] + 1, coordinates[1] + 1]))
    {
        field[coordinates[0] + 1, coordinates[1] + 1] -= bombPower; //down right
    }
    if (OutOfRangeCheck(coordinates[0] + 1, coordinates[1], size)
        && CellNotExploded(field[coordinates[0] + 1, coordinates[1]]))
    {
    field[coordinates[0] + 1, coordinates[1]] -= bombPower; //down mid
    }
    if (OutOfRangeCheck(coordinates[0], coordinates[1] + 1, size)
        && CellNotExploded(field[coordinates[0], coordinates[1] + 1]))
    {
    field[coordinates[0], coordinates[1] + 1] -= bombPower; //right
    }
    if (OutOfRangeCheck(coordinates[0] + 1, coordinates[1] - 1, size)
        && CellNotExploded(field[coordinates[0] + 1, coordinates[1] - 1]))
    {
    field[coordinates[0] + 1, coordinates[1] - 1] -= bombPower; //down left
    }

}

for (int row = 0; row < field.GetLength(0); row++)
{
    for (int col = 0; col < field.GetLength(1); col++)
    {
        if (field[row, col] > 0)
        {
            aliveCells++;
            sum += field[row, col];
        }
    }
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");

for (int row = 0; row < field.GetLength(0); row++)
{
    for (int col = 0; col < field.GetLength(1); col++)
    {
        Console.Write($"{field[row, col]} ");
    }
    Console.WriteLine();
}

static bool OutOfRangeCheck (int row, int col, int size)
{
    return row >= 0 && row < size && col >= 0 && col < size;
}

static bool CellNotExploded(int cell)
{
    return cell > 0;
}