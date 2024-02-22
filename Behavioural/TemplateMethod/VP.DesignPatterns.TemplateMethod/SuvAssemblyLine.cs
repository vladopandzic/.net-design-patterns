namespace VP.DesignPatterns.TemplateMethod;

public class SuvAssemblyLine : CarAssemblyLine
{
    protected override void InstallBody()
    {
        Console.WriteLine("Installing SUV body.");
    }

    protected override void InstallChassis()
    {
        Console.WriteLine("Installing SUV chassis.");
    }

    protected override void InstallElectonics()
    {
        Console.WriteLine("Installing SUV electronics.");
    }

    protected override void InstallEngine()
    {
        Console.WriteLine("Installing SUV engine.");
    }
}
