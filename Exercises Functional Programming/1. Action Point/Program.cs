using System;
using System.Threading.Channels;

Action<string[]> print = strings =>
    Console.WriteLine(string.Join(Environment.NewLine, strings));

string[] strings = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(strings);