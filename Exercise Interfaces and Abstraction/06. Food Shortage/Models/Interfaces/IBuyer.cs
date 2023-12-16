namespace FoodShortage.Models.Interfaces
{
    interface IBuyer : INameable
    {
        int Food { get; }
        void BuyFood();
    }
}
