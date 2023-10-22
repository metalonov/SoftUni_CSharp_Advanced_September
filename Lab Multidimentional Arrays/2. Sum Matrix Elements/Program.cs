using System.Data;

int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

int sum = 0;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowInput[col];
    }
}
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        int currentIndex = matrix[row, col];
        sum += currentIndex;
    }
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);