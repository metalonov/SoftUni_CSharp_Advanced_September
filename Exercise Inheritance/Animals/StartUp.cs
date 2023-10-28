using System;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] argums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (animalType)
                {
                    case "Cat":
                        Cat cat = new Cat(argums[0], int.Parse(argums[1]), argums[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(cat.ToString());
                        cat.ProduceSound();
                        break;
                    case "Dog":
                        Dog dog = new Dog(argums[0], int.Parse(argums[1]), argums[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(dog.ToString());
                        dog.ProduceSound();
                        break;
                    case "Frog":
                        Frog frog = new Frog(argums[0], int.Parse(argums[1]), argums[2]);
                        Console.WriteLine(animalType);
                        Console.WriteLine(frog.ToString());
                        frog.ProduceSound();
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(argums[0], int.Parse(argums[1]));
                        Console.WriteLine(animalType);
                        Console.WriteLine(kitten.ToString());
                        kitten.ProduceSound();
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(argums[0], int.Parse(argums[1]));
                        Console.WriteLine(animalType);
                        Console.WriteLine(tomcat.ToString());
                        tomcat.ProduceSound();
                        break;
                }
            }
        }
    }
}
