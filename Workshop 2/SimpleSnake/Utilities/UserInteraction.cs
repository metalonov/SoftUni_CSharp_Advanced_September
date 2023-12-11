using WorkshopSKaskata.GameObjects;

namespace WorkshopSKaskata.Utilities
{
    internal class UserInteraction
    {
        public static void Draw(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.X, gameObject.Y);
            Console.Write(gameObject.DrawSymbol);
        }
    }
}