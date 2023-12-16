using CollectionHierarchy.Models.Interfaces;

namespace CollectionHierarchy.Models;

public class MyList : IMyList
{
    private List<string> collection = new List<string>();

    public string Add(string item)
    {
        collection.Insert(0, item);
        return "0";
    }

    public string Remove()
    {
        string removedItem = collection[0];
        collection.RemoveAt(0);
        return removedItem;
    }

    public int Used => collection.Count;
}
