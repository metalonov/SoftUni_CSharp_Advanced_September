
//8
//0K0KKK00
//0K00KKKK
//00K0000K
//KKKKKK0K
//K0K0000K
//KK00000K
//00K0K000
//000K00KK

int boardSize = int.Parse(Console.ReadLine());

char[,] matrix = new char[boardSize, boardSize];
int knightsRemoved = 0;

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
    for (int row = 0; row < boardSize; row++)
    {
        for (int col = 0; col < boardSize; col++)
        {
            if (matrix[row, col] == 'K')
            {
            int knightAttacks = 0;
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
    if (maximumKnightAttacks > 0)
    {
        matrix[maxKnightRow, maxKnightCol] = '0';
        knightsRemoved++;
    }
    else
    {
        break;
    }
}

Console.WriteLine(knightsRemoved);

static bool Validate(int row, int col, int size) //out of range protection
{
    return row >= 0 && row < size && col >= 0 && col < size;
}