using System.Numerics;
using System.Security.Principal;

int[] dimentions = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int fieldWidth = dimentions[0];
int fieldHeight = dimentions[1];
char[,] field = new char[fieldWidth, fieldHeight];

int positionCol = 0;
int positionRow = 0;
bool winCondition = false;
bool loseCondition = false;

for (int row = 0; row < field.GetLength(0); row++)
{
    char[] input = Console.ReadLine()
        .ToArray();
    for (int col = 0; col < field.GetLength(1); col++)
    {
    field[row, col] = input[col];
        if (field[row, col] == 'P')
        {
            positionRow = col;
            positionCol = row;
            field[row, col] = '.';
        }
    }
}

string directions = Console.ReadLine();
int directionsLength = 0;

while (directionsLength != directions.Length)
{
    char c = directions[directionsLength];

    if (c == 'L')
    {
        if (positionRow - 1 < 0)
        {
            winCondition = true;
        }
        else if (positionRow - 1 >= 0 && field[positionCol, positionRow] == '.')
        {
            positionRow--;
        }
        if (StepOnBunny(field[positionCol, positionRow]))
        {
            loseCondition = true;
        }
    }
    if (c == 'R')
    {
        if (positionRow + 1 > fieldWidth)
        {
            winCondition = true;
        }
        else if (positionRow + 1 <= fieldHeight && field[positionCol, positionRow] == '.')
        {
            positionRow++;
        }
        if (StepOnBunny(field[positionCol, positionRow]))
        {
            loseCondition = true;
        }
    }
    if (c == 'U')
    {
        if (positionCol - 1 < 0)
        {
            winCondition = true;
        }
        else if (positionCol - 1 >= 0 && field[positionCol, positionRow] == '.')
        {
            positionCol--;
        }
        if (StepOnBunny(field[positionCol, positionRow]))
        {
            loseCondition = true;
        }
    }
    if (c == 'D')
    {
        if (positionCol + 1 > fieldHeight)
        {
            winCondition = true;
        }
        else if (positionCol + 1 <= fieldHeight && field[positionCol, positionRow] == '.')
        {
            positionCol++;
        }
        if (StepOnBunny(field[positionCol, positionRow]))
        {
            loseCondition = true;
        }
    }

    for (int row = 0; row < fieldWidth; row++)
    {
        for (int col = 0; col < fieldHeight; col++)
        {
            if (field[row, col] == 'B')
            {
                if (FieldBorderCheckUp(row - 1, col, field))
                field[row - 1, col] = 'R';
                if (FieldBorderCheckLeft(row, col - 1, field))
                field[row, col - 1] = 'R';
                if (FieldBorderCheckDown(row + 1, col, field))
                field[row + 1, col] = 'R';
                if (FieldBorderCheckRight(row, col + 1, field)) //5 4
                field[row, col + 1] = 'R';
            }
        }
    }
    for (int row = 0; row < fieldWidth; row++)
    {
        for (int col = 0; col < fieldHeight; col++)
        {
            if (field[row, col] == 'R')
            {
                field[row, col] = 'B';
            }
        }
    }

    directionsLength++;
    if (winCondition)
    {
        PrintOutMatrix(field);
        Console.WriteLine($"won: {positionCol} {positionRow}");
        break;
    }
    if (loseCondition)
    {
        PrintOutMatrix(field);
        Console.WriteLine($"dead: {positionCol} {positionRow}");
        break;
    }
}


static bool FieldBorderCheckUp(int row, int col, char[,] matrix)
{
    if (row < 0)
    {
        return false;
    }
    return true;
}
static bool FieldBorderCheckRight(int row, int col, char[,] matrix)
{
    if (col >= matrix.GetLength(1))
    {
        return false;
    }
    return true;
}
static bool FieldBorderCheckLeft(int row, int col, char[,] matrix)
{
    if (col < 0)
    {
        return false;
    }
    return true;
}
static bool FieldBorderCheckDown(int row, int col, char[,] matrix)
{
    if (row >= matrix.GetLength(0))
    {
        return false;
    }
    return true;
}

static bool StepOnBunny(char c)
{
    if (c == 'B')
    {
        return true;
    }
    return false;
}

void PrintOutMatrix(char[,] matrix)
{

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]}");
        }
        Console.WriteLine();
    }
}
