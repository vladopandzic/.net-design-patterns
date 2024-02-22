namespace VP.DesignPatterns.Builder;

public interface IComputerBuilder
{
    IComputerBuilder SetCPU(string cpu);

    IComputerBuilder BuildGPU(string gpu);

    IComputerBuilder BuildRAM(int ram);

    IComputerBuilder BuildStorage(int storage);

    Computer Build();
}