using System.Text;

int boardSize = int.Parse(Console.ReadLine()); ;

char[,] matrix = new char[boardSize, boardSize];

int gamblerX = 0;
int gamblerY = 0;
int wallet = 100;
bool jackpot = false;

for (int y = 0; y < boardSize; y++)
{
    char[] currentRow = Console.ReadLine()
        .ToArray();
    for (int x = 0; x < boardSize; x++)
    {
        matrix[y, x] = currentRow[x];
        if (matrix[y, x] == 'G')
        {
            gamblerX = x;
            gamblerY = y;
            matrix[y, x] = '-';
        }
        if (matrix[y, x] == 'J')
        {
            jackpot = true;
        }
    }
}

string command;
while ((command = Console.ReadLine()) != "end")
{
    if ((command == "left" && gamblerX == 0)
        || (command == "down" && gamblerY == matrix.GetLength(0) - 1)
        || (command == "right" && gamblerX == matrix.GetLength(1) - 1)
        || (command == "up" && gamblerY == 0)) //If the gambler steps outside
    {
        Console.WriteLine("Game over! You lost everything!");
        break;
    }
    else
    {
        switch (command)
        {
            case "up":
                gamblerY--;
                break;
            case "down":
                gamblerY++;
                break;
            case "left":
                gamblerX--;
                break;
            case "right":
                gamblerX++;
                break;
        }
    }
    if (Coordinates(matrix, gamblerY, gamblerX) == 'W')
    {
        wallet += 100;
        matrix[gamblerY, gamblerX] = '-';
    }
    if (Coordinates(matrix, gamblerY, gamblerX) == 'J')
    {
        wallet += 10000;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("You win the Jackpot!");
        sb.AppendLine($"End of the game.Total amount: {wallet}$");
        Console.WriteLine(sb.ToString().TrimEnd());
        return;
    }
    if (Coordinates(matrix, gamblerY, gamblerX) == 'P')
    {
        wallet -= 200;
        if (wallet <= 0)
        {
            Console.WriteLine("Game over! You lost everything!");
            return;
        }
    }
}

if (jackpot == true)
{
    Console.WriteLine($"End of the game. Total amount: {wallet}$");
}

matrix[gamblerY, gamblerX] = 'G';
for (int row = 0; row < boardSize; row++)
{
    for (int col = 0; col < boardSize; col++)
    {
        Console.Write(matrix[row, col]);
    }

    Console.WriteLine();
}

char Coordinates(char[,] matrix, int row, int col)
{
    return matrix[row, col];
}
