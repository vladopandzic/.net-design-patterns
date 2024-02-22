namespace VP.DesignPatterns.NullObject.Tests;

public class NullObjectTests
{
    [Test]
    public void NullProduct_Should_Return_Default_Name_When_Product_Not_Found()
    {
        // Arrange
        ProductRepository repository = new ProductRepository();

        // Act
        IProduct product = repository.FindProductById(2); // Product with ID 2 doesn't exist

        // Assert
        Assert.That(product.Name, Is.EqualTo("Product Not Found"));
    }

    [Test]
    public void NullProduct_Should_Return_Default_Price_When_Product_Not_Found()
    {
        // Arrange
        ProductRepository repository = new ProductRepository();

        // Act
        IProduct product = repository.FindProductById(2); // Product with ID 2 doesn't exist

        // Assert
        Assert.That(product.Price, Is.EqualTo(0));
    }

    [Test]
    public void NullProduct_Should_Not_Return_Null_Reference()
    {
        // Arrange
        ProductRepository repository = new ProductRepository();

        // Act
        IProduct product = repository.FindProductById(2); // Product with ID 2 doesn't exist

        // Assert
        Assert.IsNotNull(product);
    }
}