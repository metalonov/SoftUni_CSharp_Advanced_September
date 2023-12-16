using FootballTeamGenerator.IO.Interfaces;

namespace FootballTeamGenerator.IO;

public class ConsoleWriter : IWriter
{
    public void WriteLine(object obj) => Console.WriteLine(obj);
}
