int size = int.Parse(Console.ReadLine());

string[] command = Console
    .ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

char[,] matrix = new char[size, size];
int currentRow = 0;
int currentCol = 0;
int collectedCoal = 0;
int allCoal = 0;

for (int row = 0; row < size; row++)
{
    char[] words = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = words[col];
        if (words[col] == 's')
        {
            currentRow = row;
            currentCol = col;
        }
        else if (words[col] == 'c')
        {
            allCoal++;
        }
    }
}

foreach (string direction in command)
{
    switch (direction)
    {
        case "left":
            if (currentCol-1 >= 0 && currentCol - 1 <= size - 1)
            {
            currentCol--;
                if (matrix[currentRow, currentCol] == 'c')
                {
                    collectedCoal++;
                    matrix[currentRow, currentCol] = '*';
                    if (allCoal == collectedCoal)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
                else if (matrix[currentRow, currentCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
            }
            break;
        case "right":
            if (currentCol + 1 >= 0 && currentCol + 1 <= size - 1)
            {
                currentCol++;
                if (matrix[currentRow, currentCol] == 'c')
                {
                    collectedCoal++;
                    matrix[currentRow, currentCol] = '*';
                    if (allCoal == collectedCoal)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
                else if (matrix[currentRow, currentCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }

            }
            break;
        case "up":
            if (currentRow - 1 >= 0 && currentRow - 1 <= size - 1)
            {
                currentRow--;
                if (matrix[currentRow, currentCol] == 'c')
                {
                    collectedCoal++;
                    matrix[currentRow, currentCol] = '*';
                    if (allCoal == collectedCoal)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
                else if (matrix[currentRow, currentCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }

            }
            break;
        case "down":
            if (currentRow + 1 >= 0 && currentRow + 1 <= size - 1)
            {
                currentRow++;
                if (matrix[currentRow, currentCol] == 'c')
                {
                    collectedCoal++;
                    matrix[currentRow, currentCol] = '*';
                    if (allCoal == collectedCoal)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        return;
                    }
                }
                else if (matrix[currentRow, currentCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
            }
            break;
    }
}

if (allCoal > collectedCoal)
{
    Console.WriteLine($"{allCoal - collectedCoal} coals left. ({currentRow}, {currentCol})");
}