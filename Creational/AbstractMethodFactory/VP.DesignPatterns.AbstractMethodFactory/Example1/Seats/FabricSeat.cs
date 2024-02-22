namespace VP.DesignPatterns.AbstractMethodFactory.Example1.Seats;

public class FabricSeat : ISeat
{
    public void ChooseMaterial()
    {
        Console.WriteLine("Fabric seats installed.");
    }
}
