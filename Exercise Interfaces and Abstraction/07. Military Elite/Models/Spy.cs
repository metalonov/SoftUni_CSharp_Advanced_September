using MilitaryElite.Models.Interfaces;
namespace MilitaryElite.Models;
public class Spy : Soldier, ISpy
{
    public Spy(int id, string firstName, string lastName, int codeNum)
        : base(id, firstName, lastName)
    {
        CodeNum = codeNum;
    }
    public int CodeNum { get; private set; }
    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Code Number: {CodeNum}";
    }
}
