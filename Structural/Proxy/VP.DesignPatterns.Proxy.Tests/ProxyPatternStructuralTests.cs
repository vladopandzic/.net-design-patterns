namespace VP.DesignPatterns.Proxy.Tests;

public class ProxyPatternStructuralTests
{
    [Test]
    public void Proxy_Should_Implement_Interface()
    {
        // Arrange
        IImageLoader proxy = new ImageProxy();

        // Act & Assert
        Assert.That(proxy, Is.InstanceOf<IImageLoader>());
    }

    [Test]
    public void Proxy_Can_Load_Image_From_Cache()
    {
        // Arrange
        IImageLoader proxy = new ImageProxy();
        string imageName = "example.jpg";
        string expectedOutput = $"Image '{imageName}' found in cache. Returning cached image.";

        using (StringWriter sw = new StringWriter())
        {
            // Act
            Console.SetOut(sw);
            proxy.LoadImage(imageName); // Load image once to cache it
            sw.GetStringBuilder().Clear(); // Clear StringWriter
            proxy.LoadImage(imageName); // Load image again from cache
            string consoleOutput = sw.ToString().Trim();

            // Assert
            Assert.That(consoleOutput, Is.EqualTo(expectedOutput));
        }
    }
}