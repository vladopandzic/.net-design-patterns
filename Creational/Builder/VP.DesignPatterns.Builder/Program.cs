namespace VP.DesignPatterns.Builder;

internal class Program
{
    static void Main(string[] args)
    {
        IComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();

        Computer computer = gamingComputerBuilder
            .SetCPU("Intel Core i9")
            .BuildGPU("NVIDIA GeForce RTX 3080")
            .BuildRAM(32)
            .BuildStorage(1000)
            .Build();

        var computerEngineer = new ComputerEngineer(gamingComputerBuilder);

        computerEngineer.ConstructComputer();

        var computer2 = computerEngineer.GetComputer();

        computer.Display();

        computer2.Display();

    }
}
