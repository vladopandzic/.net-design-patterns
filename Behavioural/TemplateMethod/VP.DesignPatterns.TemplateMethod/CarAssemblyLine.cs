namespace VP.DesignPatterns.TemplateMethod;

public abstract class CarAssemblyLine
{
    public void AssembleCar()
    {
        InstallChassis();
        InstallEngine();
        InstallBody();
        InstallElectonics();
        Paint();
    }

    protected abstract void InstallChassis();

    protected abstract void InstallEngine();

    protected abstract void InstallBody();

    protected abstract void InstallElectonics();

    // Default implementation for painting
    protected virtual void Paint()
    {
        Console.WriteLine("Painting car...");
    }
}
