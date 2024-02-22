namespace VP.DesignPatterns.Proxy;

internal class Program
{
    static void Main(string[] args)
    {
        IImageLoader imageLoader = new ImageProxy();

        imageLoader.LoadImage("image1.jpg");

        imageLoader.LoadImage("image1.jpg");

        imageLoader.LoadImage("image2.jpg");

        Console.ReadKey();
    }
}
