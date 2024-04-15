namespace VP.DesignPatterns.ChainOfResponsibility;

public class Car
{
    public Car(int id, string chassisMaterial, string engineType)
    {
        Id = id;
        ChassisMaterial = chassisMaterial;
        EngineType = engineType;
    }

    public int Id { get; set; }

    public string ChassisMaterial { get; set; }

    public string EngineType { get; set; }
}