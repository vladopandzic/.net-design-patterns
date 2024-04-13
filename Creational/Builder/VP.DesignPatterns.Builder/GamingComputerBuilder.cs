namespace VP.DesignPatterns.Builder;
// Concrete builder class

public class GamingComputerBuilder : IComputerBuilder
{
    private Computer computer;

    public GamingComputerBuilder()
    {
        computer = new Computer();
    }

    public IComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder BuildGPU(string gpu)
    {
        computer.GPU = gpu;
        return this;
    }

    public IComputerBuilder BuildRAM(int ram)
    {
        computer.RAM = ram;
        return this;
    }

    public IComputerBuilder BuildStorage(int storage)
    {
        computer.Storage = storage;
        return this;
    }

    public Computer Build()
    {
        return computer;
    }
}
