int[] size = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => int.Parse(n)) //парсване с фукнция
        .ToArray();

char[,] matrix = new char[size[0], size[1]];

int count = 0;
int maxCount = 0;


for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] rowInput = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => char.Parse(n)) //парсване с фукнция
        .ToArray();
    for (int col = 0; col < size[1]; col++)
    {
        matrix[row, col] = rowInput[col];
    }
}

for (int row = 0; row < size[0] - 1; row++)
{
    for (int col = 0; col < size[1] - 1; col++)
    {
        char element = matrix[row, col];
        if (element == matrix[row + 1, col] && element == matrix[row, col + 1] && element == matrix[row + 1, col + 1])
        {
            count++;
            if (count > maxCount)
            {
                maxCount = count;
            }
        }
    }
}

Console.WriteLine(maxCount);