namespace VP.DesignPatterns.ChainOfResponsibility;

internal class Program
{
    static void Main(string[] args)
    {
        // Set up the chain of responsibility
        AssemblyZone carAssembler = new ChassisAssemblyZone();

        carAssembler.SetNextZone(new EngineAssemblyZone())
                .SetNextZone(new InteriorAssemblyZone());


        var car = new Car(1, "Steel", "Petrol");
        var sucessFullyAssembled = carAssembler.Assemble(car);

        Console.WriteLine(sucessFullyAssembled);

        var car2 = new Car(1, "Steel", "Diesel");
        var sucessFullyAssembled2 = carAssembler.Assemble(car2);

        Console.WriteLine(sucessFullyAssembled2);

    }
}
