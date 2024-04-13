namespace VP.DesignPatterns.Prototype;

public interface IEmployeePrototype
{
    IEmployeePrototype Clone();

    void Display();
}
