using System.Reflection;
using VP.DesignPatterns.Bridge.Example2;

namespace VP.DesignPatterns.Bridge.Tests.Example2;

public class BridgePatternExample2StructuralTests
{
    [Test, Description("Inside abstraction implementors should be interchangeable since abstraction has only reference to (abstract impelementor)")]
    public void Implementors_Should_Be_Interchangeable()
    {
        // Arrange
        IColor redColor = new RedColor();
        IColor blueColor = new BlueColor();

        // Act
        Shape redCircle = new Circle(redColor);
        Shape blueCircle = new Circle(blueColor);

        // Assert
        Assert.That(redCircle.Draw(), Is.EqualTo("Drawing Circle. Filled with Red color."));
        Assert.That(blueCircle.Draw(), Is.EqualTo("Drawing Circle. Filled with Blue color."));
    }

    [Test, Description("Abstractions accept implementor (interface) inside constructor.")]
    public void Abstraction_Constructor_Should_Accept_Abstract_Implementor_Only()
    {
        // Arrange
        Type abstractionType = typeof(Shape);
        Type abstractImplementorType = typeof(IColor);

        // Act
        ConstructorInfo constructor = abstractionType.GetConstructors().FirstOrDefault()!;

        // Assert
        Assert.IsNotNull(constructor, $"Constructor not found in {abstractionType.Name}");
        ParameterInfo[] parameters = constructor.GetParameters();
        Type parameterType = parameters[0].ParameterType;
        Assert.IsTrue(parameterType.IsInterface && parameterType.IsAssignableFrom(abstractImplementorType),
                      $"Constructor of {abstractionType.Name} should accept only abstract implementor types");
    }
}
