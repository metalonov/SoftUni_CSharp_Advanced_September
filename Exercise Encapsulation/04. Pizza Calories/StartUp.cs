using FootballTeamGenerator.Core;
using FootballTeamGenerator.Core.Interfaces;
using FootballTeamGenerator.Factories;
using FootballTeamGenerator.Factories.Interfaces;
using FootballTeamGenerator.IO;
using FootballTeamGenerator.IO.Interfaces;

namespace FootballTeamGenerator;

public class StartUp
{
    static void Main()
    {
        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        IItemFactory itemFactory = new ItemFactory();

        IEngine engine = new Engine(reader, writer, itemFactory);

        engine.Run();
    }
}