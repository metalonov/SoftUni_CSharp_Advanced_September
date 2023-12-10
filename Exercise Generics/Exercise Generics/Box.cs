using System.Text;

namespace Exercise_Generics;

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
            
            sb.AppendLine($"{item.GetType()}: {item}");
        }
        return sb.ToString().Trim();
    }
}
