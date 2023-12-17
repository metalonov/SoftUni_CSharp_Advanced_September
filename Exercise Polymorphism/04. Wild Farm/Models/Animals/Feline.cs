﻿namespace WildFarm.Models.Animals;

public abstract class Feline : Mammal
{
    public Feline(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion)
    {
        Breed = breed;
    }
    public string Breed { get; private set; }
    public override string ToString() => base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
}
