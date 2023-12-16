using CollectionHierarchy.Models.Interfaces;

namespace CollectionHierarchy.Models;

public class AddCollection : IAddCollection
{
    private List<string> collection = new List<string>();

    public string Add(string item)
    {
        collection.Add(item);
        return $"{collection.Count - 1}";
    }
}
