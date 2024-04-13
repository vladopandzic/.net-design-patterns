namespace VP.DesignPatterns.NullObject;

public class Product : IProduct
{
    public string Name { get; }

    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}
