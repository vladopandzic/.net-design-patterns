namespace VP.DesignPatterns.Visitor;

public interface IEmployeeVisitor
{
    void Visit(EngineeringManager engineeringManager);

    void Visit(ProductManager productManager);

    void Visit(SoftwareEngineer softwareEngineer);

}
