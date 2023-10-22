using System.Diagnostics;

int[] size = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(n => int.Parse(n)) //парсване с фукнция
        .ToArray();


int rows = size[0];
int cols = size[1];

string[,] matrix = new string[size[0], size[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] words = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < size[1]; col++)
    {
        matrix[row, col] = words[col];
    }
}

string command;
while ((command = Console.ReadLine()) != "END")
{

    if (RangeCheck(command, rows, cols))
    {
        string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int row1 = int.Parse(arguments[1]);
        int col1 = int.Parse(arguments[2]);
        int row2 = int.Parse(arguments[3]);
        int col2 = int.Parse(arguments[4]);

        string num1 = matrix[row1, col1];
        string num2 = matrix[row2, col2];
        matrix[row1, col1] = num2;
        matrix[row2, col2] = num1;
        PrintMatrix(matrix); 
    }
    else
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
}


static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}
bool RangeCheck(string command, int rows, int cols)
{
    string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    bool isValidName = arguments[0] == "swap";
    bool isValidParts = arguments.Length == 5;
    bool isValidRange = false;
    if (isValidName && isValidParts)
    {
        int row1 = int.Parse(arguments[1]);
        int col1 = int.Parse(arguments[2]);
        int row2 = int.Parse(arguments[3]);
        int col2 = int.Parse(arguments[4]);
        isValidRange = row1 >= 0 && row1 < rows
            && col1 >= 0 && col1 < cols
            && row2 >= 0 && row2 < rows 
            && col2 >= 0 && col2 < cols;

    }
    return isValidName && isValidParts && isValidRange;
}
