namespace VP.DesignPatterns.NullObject;
public class ProductRepository
{
    public IProduct FindProductById(int productId)
    {
        // In a real application, this would fetch product data from a database or external service
        if (productId == 1)
        {
            return new Product("Smartphone", 499.99m);
        }
        else
        {
            return new NullProduct(); // Return NullProduct if product not found
        }
    }
}
