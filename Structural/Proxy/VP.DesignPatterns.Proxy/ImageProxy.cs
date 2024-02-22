namespace VP.DesignPatterns.Proxy;

public class ImageProxy : IImageLoader
{
    private readonly ImageLoader realImageLoader;
    private readonly Dictionary<string, bool> cache;

    public ImageProxy()
    {
        realImageLoader = new ImageLoader();
        cache = new Dictionary<string, bool>();
    }

    public void LoadImage(string imageName)
    {
        if(cache.ContainsKey(imageName) && cache[imageName])
        {
            Console.WriteLine($"Image '{imageName}' found in cache. Returning cached image.");
        }
        else
        {
            realImageLoader.LoadImage(imageName);
            cache[imageName] = true;
        }
    }
}