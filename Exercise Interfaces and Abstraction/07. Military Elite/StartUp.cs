using MilitaryElite.Core;
using MilitaryElite.Core.Interfaces;

namespace MilitaryElite;

public class StartUp
{
    static void Main()
    {
        IEngine engine = new Engine();
        engine.Run();
    }
}
