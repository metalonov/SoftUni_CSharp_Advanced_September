using _3.ShoppingSpree;

string[] separator = { "=", ";" };
List<Person> people = new();
List<Product> products = new();

try
{
    string[] allPeople = Console.ReadLine()
        .Split(separator, StringSplitOptions.RemoveEmptyEntries)
        .ToArray();


    string[] allProducts = Console.ReadLine()
        .Split(separator, StringSplitOptions.RemoveEmptyEntries)
        .ToArray();


    for (int i = 0; i < allPeople.Length; i++)
    {
        Person person = new(allPeople[i], decimal.Parse(allPeople[i + 1]));
        people.Add(person);
        i++;
    }
    for (int i = 0; i < allProducts.Length; i++)
    {
        Product product = new(allProducts[i], decimal.Parse(allProducts[i + 1]));
        products.Add(product);
        i++;
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
    return;
}

string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string temp1 = arguments[0];
    string temp2 = arguments[1];
    Person person = people.FirstOrDefault(p => p.Name == temp1);
    Product product = products.FirstOrDefault(p => p.Name == temp2);

    if (person is not null && product is not null)
    {
        person.BuyProduct(product);
    }
}
foreach (var person in people)
{
    Console.WriteLine(person);
}
