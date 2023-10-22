
int boardSize = int.Parse(Console.ReadLine());

char[,] matrix = new char[boardSize, boardSize];
int knightsRemoved = 0;
int knightAttacks = 0;

for (int row = 0; row < boardSize; row++)
{
    char[] rows = Console.ReadLine()
        .ToArray();
    for (int col = 0; col < boardSize; col++)
    {
            matrix[row, col] = rows[col];
    }
}

if (boardSize < 3)
{
    Console.WriteLine(0);
    return;
}

while (true)
{
    int maxKnightRow = 0;
    int maxKnightCol = 0;
    int maximumKnightAttacks = 0;
    knightAttacks = 0;
    for (int row = 0; row < boardSize; row++)
    {
        for (int col = 0; col < boardSize; col++)
        {
            if (matrix[row, col] == 'K')
            {
                if (Validate(row - 2, col - 1, boardSize))
                {
                    if (matrix[row - 2, col - 1] == 'K') //1
                    {
                        knightAttacks++;
                    }
                }
                if (Validate(row - 1, col - 2, boardSize))
                {
                    if (matrix[row - 1, col - 2] == 'K') //2
                    {
                        knightAttacks++;
                    }
                }
                if (Validate(row - 2, col + 1, boardSize))
                {
                    if (matrix[row - 2, col + 1] == 'K') //3
                    {
                        knightAttacks++;
                    }
                }
                if (Validate(row - 1, col + 2, boardSize))
                {
                    if (matrix[row - 1, col + 2] == 'K') //4
                    {
                        knightAttacks++;
                    }
                }
                if (Validate(row + 1, col + 2, boardSize))
                {
                    if (matrix[row + 1, col + 2] == 'K') //5
                    {
                        knightAttacks++;
                    }
                }
                if (Validate(row + 2, col + 1, boardSize))
                {
                    if (matrix[row + 2, col + 1] == 'K') //6
                    {
                        knightAttacks++;
                    }
                }
                if (Validate(row + 2, col - 1, boardSize))
                {
                    if (matrix[row + 2, col - 1] == 'K') //7
                    {
                        knightAttacks++;

                    }
                }
                if (Validate(row + 1, col - 2, boardSize))
                {
                    if (matrix[row + 1, col - 2] == 'K') //8
                    {
                        knightAttacks++;
                    }
                }
                if (knightAttacks > maximumKnightAttacks)
                {
                    maximumKnightAttacks = knightAttacks;
                    maxKnightCol = col;
                    maxKnightRow = row;
                }
            }
        }
    }
    if (maximumKnightAttacks == 0)
    {
        break;
    }
    else
    {
        matrix[maxKnightRow, maxKnightCol] = '0';
        knightsRemoved++;
    }
}

Console.WriteLine(knightsRemoved);

static bool Validate(int row, int col, int size) //out of range protection
{
    return row >= 0 && row < size && col >= 0 && col < size;
}