namespace VP.DesignPatterns.Builder;

public class ComputerEngineer
{
    readonly IComputerBuilder computerBuilder;

    public ComputerEngineer(IComputerBuilder builder)
    {
        computerBuilder = builder;
    }

    public void ConstructComputer()
    {
        computerBuilder.SetCPU("Intel i9");
        computerBuilder.BuildGPU("NVIDIA RTX 3080");
        computerBuilder.BuildRAM(32);
        computerBuilder.BuildStorage(1);
    }

    public Computer GetComputer()
    {
        return computerBuilder.Build();
    }
}