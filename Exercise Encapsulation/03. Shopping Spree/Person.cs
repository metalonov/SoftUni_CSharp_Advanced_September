namespace _3.ShoppingSpree;

public class Person
{
    private string name;
    private decimal money;
    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Bag = new List<Product>();
    }
    public string Name
    {
        get
        {
            return name;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.NameEmpty);
            }
            this.name = value;
        }
    }
    public decimal Money
    {
        get
        {
            return this.money;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(ExceptionMessages.MoneyNegative);
            }
            this.money = value;
        }
    }
    public List<Product> Bag { get; set; }
    public void BuyProduct(Product product)
    {
        if (Money >= product.Cost)
        {
            Money -= product.Cost;
            Bag.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
    }

    public override string ToString()
    {
        if (Bag.Count == 0)
        {
            return $"{Name} - Nothing bought";
        }
        else
        {
            return $"{Name} - {string.Join(", ", Bag)}";
        }
    }
}
