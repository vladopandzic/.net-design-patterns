namespace VP.DesignPatterns.NullObject;

internal class Program
{
    static void Main(string[] args)
    {
        ProductRepository repository = new ProductRepository();


        IProduct product1 = repository.FindProductById(1);
        Console.WriteLine($"Product Name: {product1.Name}, Price: {product1.Price}");

        IProduct product2 = repository.FindProductById(2);
        Console.WriteLine($"Product Name: {product2.Name}, Price: {product2.Price}");
    }
}
