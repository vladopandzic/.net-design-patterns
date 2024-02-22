namespace VP.DesignPatterns.AbstractMethodFactory.Example1.Seats;

public class LeatherSeat : ISeat
{
    public void ChooseMaterial()
    {
        Console.WriteLine("Leather seats installed.");
    }
}
