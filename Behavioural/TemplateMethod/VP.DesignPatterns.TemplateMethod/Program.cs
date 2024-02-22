namespace VP.DesignPatterns.TemplateMethod;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Building a sports car:");
        CarAssemblyLine sportsCarLine = new SportsCarAssemblyLine();
        sportsCarLine.AssembleCar();

        Console.WriteLine();

        Console.WriteLine("Building an SUV:");
        CarAssemblyLine suvLine = new SuvAssemblyLine();
        suvLine.AssembleCar();
    }
}
