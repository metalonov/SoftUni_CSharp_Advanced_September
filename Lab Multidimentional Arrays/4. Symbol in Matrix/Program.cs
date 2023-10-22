int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];
bool notFound = false;

for (int row = 0; row < n; row++)
{
    char[] rowInput = Console.ReadLine()
        .ToCharArray();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = rowInput[col];
    }

}
char ch = char.Parse(Console.ReadLine());

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == ch)
        {
            Console.WriteLine($"({row}, {col})");
            notFound = true;
            return;
        }
    }
}

if (notFound == false)
{
    Console.WriteLine($"{ch} does not occur in the matrix");
}
