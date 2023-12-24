﻿using SimpleSnake.Core;
using SimpleSnake.GameObjects;
using SimpleSnake.Utilities;

public class StartUp
{
    public static void Main()
    {
        ConsoleWindow.CustomizeConsole();
        Wall borders = new Wall(60, 20);
        borders.Draw();

        Snake snake = new Snake();
        Engine engine = new Engine(borders, snake);

        engine.Start();

        Console.WriteLine();
        Console.WriteLine();
    }
}