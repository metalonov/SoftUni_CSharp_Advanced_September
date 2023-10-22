int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];
int primarySum = 0;
int secondarySum = 0;

for (int row = 0; row < n; row++)
{
    int[] rowInput = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => int.Parse(n)) //парсване с фукнция
        .ToArray();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = rowInput[col];
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    primarySum += matrix[i, i]; //фомула за сумиране на първичен диагонал в кв. матрица
    secondarySum += matrix[i, matrix.GetLength(1) - i - 1]; //формула за сумиране на вторичен/обратен диагонал
}

Console.WriteLine(Math.Abs(primarySum - secondarySum));