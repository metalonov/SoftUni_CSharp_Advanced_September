int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
    matrix[row] = rowValues;
}

string command = "";

while ((command = Console.ReadLine().ToLower()) != "end")
{
    string[] arguments = command.Split();
        int row = int.Parse(arguments[1]);
        int col = int.Parse(arguments[2]);
        int val = int.Parse(arguments[3]);
        if (row >= 0 && col >= 0 && row < matrix.Length && matrix[row].Length > col)
        {
            if (arguments[0] == "add")
            {

                matrix[row][col] += val;
            }
            else//(arguments[0] == "remove")
            {

                matrix[row][col] -= val;
            }
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
}

for (int row = 0; row < matrix.Length; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write($"{matrix[row][col]} ");
    }
    Console.WriteLine();
}