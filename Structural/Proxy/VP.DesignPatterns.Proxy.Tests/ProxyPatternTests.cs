namespace VP.DesignPatterns.Proxy.Tests;

public class ProxyPatternTests
{
    [Test]
    public void Proxy_Caches_Image_After_First_Load()
    {
        // Arrange
        IImageLoader proxy = new ImageProxy();
        string imageName = "example.jpg";

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            proxy.LoadImage(imageName);
            string firstLoadOutput = sw.ToString().Trim();
            sw.GetStringBuilder().Clear();

            proxy.LoadImage(imageName);
            string secondLoadOutput = sw.ToString().Trim();

            // Assert
            Assert.That(firstLoadOutput, Does.Contain($"Loading image '{imageName}' from remote server..."));
            Assert.That(firstLoadOutput, Does.Contain($"Image '{imageName}' loaded successfully."));

            Assert.That(secondLoadOutput, Does.Contain($"Image '{imageName}' found in cache. Returning cached image."));
        }
    }
}
