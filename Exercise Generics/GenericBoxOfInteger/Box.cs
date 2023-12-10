using System.Text;

namespace GenericBoxOfInteger;

public class Box<T>
{
    private List<T> _items;

    public Box()
    {
        _items = new();
    }

    public void Add(T item)
    {
        _items.Add(item);
    }
    public override string ToString()
    {
        StringBuilder sb = new();
        foreach (T? item in _items)
        {
            
            sb.AppendLine($"{typeof(T)}: {item}");
        }
        return sb.ToString().Trim();
    }
}
