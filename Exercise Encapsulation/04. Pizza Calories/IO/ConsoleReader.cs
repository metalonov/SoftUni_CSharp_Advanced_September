using FootballTeamGenerator.IO.Interfaces;

namespace FootballTeamGenerator.IO;

public class ConsoleReader : IReader
{
    public string ReadLine() => Console.ReadLine();
}
