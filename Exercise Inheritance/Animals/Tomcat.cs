using System;
using System.Security.Cryptography;

namespace Animals
{
    public class Tomcat : Cat
    {
        public const string Sound = "MEOW";

        private const string TomcatGender = "male";
        public Tomcat(string name, int age) : base(name, age, TomcatGender)
        {

        }

        public override string ProduceSound() => Sound;
    }
}
