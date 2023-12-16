using ExplicitInterfaces.Models;
using ExplicitInterfaces.Models.Interfaces;

string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input
        .Split();

    Citizen citizen = new(tokens[0], tokens[1], int.Parse(tokens[2]));

    Console.WriteLine($"{((IPerson)citizen).GetName()}");
    Console.WriteLine($"{((IResident)citizen).GetName()}{((IPerson)citizen).GetName()}");

}