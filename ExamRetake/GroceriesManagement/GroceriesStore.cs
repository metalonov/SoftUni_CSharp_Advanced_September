using System.Text;

namespace GroceriesManagement;

public class GroceriesStore
{
    public GroceriesStore(int capacity)
    {
        Capacity = capacity;
        Turnover = 0;
        Stall = new List<Product>();
    }

    public int Capacity { get; private set; }
    public double Turnover { get; private set; }
    public List<Product> Stall { get; private set; }

    public void AddProduct(Product product)
    {
        if (!Stall.Contains(product) && Stall.Count < Capacity)
        {
            Stall.Add(product);
        }
    }
    public bool RemoveProduct(string name) => Stall.Remove(Stall.FirstOrDefault(p => p.Name == name));
    public string SellProduct(string name, double quantity)
    {
        if (Stall.Any(p => p.Name == name))
        {
            Product product = Stall.First(p => p.Name == name);
            Turnover += Math.Round(product.Price * quantity, 2);
            return $"{name} - {product.Price * quantity:F2}$";
        }
        return "Product not found";
    }

    public Product GetMostExpensive() => Stall.MaxBy(p => p.Price);

    public string CashReport()
    {
        return string.Format($"Total Turnover: {Turnover:F2}$");
    }

    public string PriceList()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Groceries Price List:");
        foreach (var product in Stall)
        {
            sb.AppendLine(product.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}
