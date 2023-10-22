using System.Data;

int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

int rowSum = 0;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowInput[col];
    }
}
for (int col = 0; col < cols; col++)
{
    for (int row = 0; row < rows; row++)
    {
        rowSum += matrix[row, col];
    }
    Console.WriteLine(rowSum);
    rowSum = 0;
}
