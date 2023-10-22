﻿int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];


for (int row = 0; row < size; row++)
{
    int[] cells = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = cells[col];
    }
}

string command;

while (true)
{

}