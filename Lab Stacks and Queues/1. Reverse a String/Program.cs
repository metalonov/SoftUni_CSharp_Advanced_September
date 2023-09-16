using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

Stack<char> stack = new Stack<char>();

string str = Console.ReadLine();

foreach (var item in str)
{
    stack.Push(item);
}

while (stack.Count > 0)
{
    Console.Write(stack.Pop());
}