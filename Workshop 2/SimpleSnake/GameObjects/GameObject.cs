using WorkshopSKaskata.Core.Interfaces;
using WorkshopSKaskata.Utilities;

namespace WorkshopSKaskata.GameObjects;

public class GameObject : Point, IDrawable
{
    public char DrawSymbol { get; }
    public GameObject(char drawSymbol) : base(0, 0)
    {
        DrawSymbol = drawSymbol;
    }
    public GameObject(char drawSymbol, int x, int y) : base(x, y)
    {
        DrawSymbol = drawSymbol;
    }


    public virtual void Draw()
    {
        UserInteraction.Draw(this);
    }
}
