using WorkshopSKaskata.GameObjects;
using WorkshopSKaskata.Utilities;

public class StartUp
{
    static void Main()
    {
        ConsoleWindow.CustomizeConsole();
        Wall borders = new Wall(60, 20);
        borders.Draw();
        //Snake snake = new Snake();
        //Engine engine = new Engine(wall, snake);
        //engine.Run();
        Console.WriteLine();
        Console.WriteLine();
    }
}