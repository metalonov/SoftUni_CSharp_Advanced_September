namespace CustomStack;

public class StackOfStrings : Stack<string>
{
    private Stack<string> customStack;

    public StackOfStrings()
    {
        customStack = new();
    }

    public bool IsEmpty()
    {
        if (customStack.Count != 0)
        {
            return true;
        }
        return false;
    }

    public void AddRange(Stack<string> stackRange)
    {
        foreach (var item in stackRange)
        {
            customStack.Push(item);
        }
    }
}
