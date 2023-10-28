namespace Animals
{
    public class Kitten : Cat
    {
        public const string Sound = "Meow"
            ;
        private const string KittenGender = "female";
        public Kitten(string name, int age) : base(name, age, KittenGender)
        {

        }

        public override string ProduceSound() => Sound;
    }
}
