namespace VP.DesignPatterns.ChainOfResponsibility;

public class ChassisAssemblyZone : AssemblyZone
{
    public override bool Assemble(Car part)
    {
        if (part.ChassisMaterial != "Carbon")
        {
            Console.WriteLine("Assembled chassis");
            return _nextZone?.Assemble(part) ?? true;
        }
        return false;
    }
}
