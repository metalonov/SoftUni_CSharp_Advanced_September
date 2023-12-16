using CollectionHierarchy.Models.Interfaces;

namespace CollectionHierarchy.Models;

public class AddRemoveCollection : IAddRemoveCollection
{
    private List<string> collection = new List<string>();

    public string Add(string item)
    {
        collection.Insert(0, item);
        return "0";
    }

    public string Remove()
    {
        string removedItem = collection[collection.Count - 1];
        collection.RemoveAt(collection.Count - 1);
        return removedItem;
    }

}