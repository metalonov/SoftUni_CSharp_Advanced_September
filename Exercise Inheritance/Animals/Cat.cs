using System;

namespace Animals
{
    public class Cat : Animal
    {
        public const string Sound = "Meow meow";
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound() => Sound;
    }
}
