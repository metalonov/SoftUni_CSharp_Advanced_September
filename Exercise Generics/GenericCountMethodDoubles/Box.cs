namespace GenericCountMethodSDouble;

public class Box<T> where T : IComparable<T>
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
    public int Count(T itemToCompare)
    {
        int counts = 0;
        foreach (var items in _items)
        {
            if (items.CompareTo(itemToCompare) > 0)
            {
                counts++;
            }
        }
        return counts;
    }
}
