int n = int.Parse(Console.ReadLine());


int sum = 0;
int[,] matrix = new int[n,n];

for (int row = 0; row < n; row++)
{
    int[] rowInput = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = rowInput[col];
    }

}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    sum += matrix[i, i];
}

Console.WriteLine(sum);