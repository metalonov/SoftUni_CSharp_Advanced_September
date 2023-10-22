int[] size = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => int.Parse(n)) //парсване с фукнция
        .ToArray();

int[,] matrix = new int[size[0], size[1]];
int[,] maximalMatrix = new int[3, 3];

int matrixSum = 0;
int biggestMatrixSum = 0;


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowInput = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => int.Parse(n)) //парсване с фукнция
        .ToArray();
    for (int col = 0; col < size[1]; col++)
    {
        matrix[row, col] = rowInput[col];
    }
}

for (int row = 0; row < size[0] - 2; row++)
{
    for (int col = 0; col < size[1] - 2; col++)
    {
        matrixSum = matrix[row, col] +
            matrix[row + 1, col] +
            matrix[row + 2, col] +
            matrix[row, col + 1] +
            matrix[row + 1, col + 1] +
            matrix[row + 2, col + 1] +
            matrix[row, col + 2] +
            matrix[row + 1, col + 2] +
            matrix[row + 2, col + 2];

            if (matrixSum > biggestMatrixSum)
            {
            biggestMatrixSum = matrixSum;
                for (int maximalRow = 0; maximalRow < 3; maximalRow++)
                {
                    for (int maximalCol  = 0; maximalCol < 3; maximalCol++)
                    {
                            maximalMatrix[maximalRow, maximalCol] = matrix[row + maximalRow, col + maximalCol];
                    }
                }
            }
    }
}

Console.WriteLine($"Sum = {biggestMatrixSum}");
for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write($"{maximalMatrix[row, col]} ");
    }
    Console.WriteLine();
}