namespace CustomStack;
public class StartUp
{
    private static void Main()
    {
        StackOfStrings stack = new StackOfStrings();

        Stack<string> newstack = new();
        newstack.Push("adf");
        newstack.Push("adf");
        newstack.Push("adf");


        Console.WriteLine(stack.IsEmpty());

        stack.AddRange(newstack);

        Console.WriteLine(stack.IsEmpty());
    }
}