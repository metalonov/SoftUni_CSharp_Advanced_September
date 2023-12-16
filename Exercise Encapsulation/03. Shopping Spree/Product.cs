namespace _3.ShoppingSpree

{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
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
        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.MoneyNegative);
                }
                this.cost = value;
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
