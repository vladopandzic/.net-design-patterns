namespace VP.DesignPatterns.NullObject;
public class NullProduct : IProduct
{
    public string Name => "Product Not Found";
    public decimal Price => 0;
}
