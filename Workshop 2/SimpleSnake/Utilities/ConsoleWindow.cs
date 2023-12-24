using System.Runtime.InteropServices;
using System.Text;

namespace SimpleSnake.Utilities;

public class ConsoleWindow
{
    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern IntPtr GetConsoleWindow();
    private static IntPtr ThisConsole = GetConsoleWindow();
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    private const int MAXIMIZE = 3;
    public static void CustomizeConsole()
    {
        Console.OutputEncoding = Encoding.Unicode;
        ShowWindow(ThisConsole, MAXIMIZE);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.CursorVisible = false;
    }
}
