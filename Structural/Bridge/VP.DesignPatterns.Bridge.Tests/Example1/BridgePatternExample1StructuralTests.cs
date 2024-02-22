using System.Reflection;
using VP.DesignPatterns.Bridge.Example1;
namespace VP.DesignPatterns.Bridge.Tests.Example1;


public class BridgePatternExample1StructuralTests
{
    private StringWriter _stringWriter;


    [SetUp]
    public void Setup()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
    }

    [Test, Description("Each refined abstraction has reference to IRemoteControl")]
    public void Abstraction_Should_Reference_ConcreteImplementor()
    {
        // Arrange
        Type baseTypeForAbstraction = typeof(ElectronicDevice);
        Type typeOfImplementorThatAbstactionHas = typeof(IRemoteControl);

        Assembly assembly = baseTypeForAbstraction.Assembly;
        var subclasses = assembly.GetTypes().Where(type => type.IsSubclassOf(baseTypeForAbstraction));

        // Act && Assert
        foreach (Type subclass in subclasses)
        {
            bool containsField = HasFieldOfType(subclass, typeOfImplementorThatAbstactionHas);
            Assert.That(containsField, Is.True,
                $"Subclass '{subclass.Name}' does not contain a field of type '{typeOfImplementorThatAbstactionHas.Name}'.");
        }
    }

    [Test, Description("Each refined abstraction should reference implementor.")]
    public void Abstraction_Should_Reference_Implementor()
    {
        //Arrange
        var refinedAbstractionTypes = GetTypesImplementingInterface<ElectronicDevice>();

        //Act && Assert
        foreach (var abstractionType in refinedAbstractionTypes)
        {
            var implementorType = typeof(IRemoteControl);
            FieldInfo? field = GetFieldOfType(abstractionType, implementorType);
            Assert.IsNotNull(field, $"Abstraction '{abstractionType.Name}' does not contain a reference to an implementor.");
        }
    }

    [Test, Description("Implementor should now know of any abstraction.")]
    public void Implementor_Should_Be_Independent_Of_Abstraction()
    {
        var implementorTypes = GetTypesImplementingInterface<IRemoteControl>();

        foreach (var implementorType in implementorTypes)
        {
            var abstractionType = typeof(ElectronicDevice);
            var fields = implementorType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                        .Where(f => f.FieldType.GetInterfaces().Contains(abstractionType));
            Assert.IsEmpty(fields, $"Implementor '{implementorType.Name}' depends on abstraction.");
        }
    }

    [Test, Description("Abstractions can accept any concrete implementors.")]
    public void Abstraction_Should_Be_Flexible_And_Extensible()
    {
        // Arrange
        var implementorA = new BasicRemoteControl();
        var implementorB = new AdvancedRemoteControl();
        var abstraction = new DVDPlayer(implementorA);

        // Act
        abstraction.PowerOn();
        var basicRemoteMessage = _stringWriter.ToString().Trim();
        abstraction.SetRemoteControl(implementorB);
        _stringWriter.GetStringBuilder().Clear();
        abstraction.PowerOn();
        var advancedRemoteMessage = _stringWriter.ToString().Trim();

        // Assert
        Assert.That(basicRemoteMessage, Is.EqualTo("Turning the device ON using basic remote control."));
        Assert.That(advancedRemoteMessage, Is.EqualTo("Activating power using advanced remote control."));

    }

    [Test, Description("Abstraction delegate behavior to concrete implementor.")]
    public void Abstraction_Should_Delegate_Operation_To_Implementor()
    {
        // Arrange
        var implementor = new BasicRemoteControl();
        var abstraction = new TV(implementor);

        // Act
        abstraction.PowerOn();

        // Assert
        Assert.That(_stringWriter.ToString().Trim(), Is.EqualTo("Turning the device ON using basic remote control."));
    }

    private static FieldInfo? GetFieldOfType(Type abstractionType, Type implementorType)
    {
        return abstractionType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                              .FirstOrDefault(f => f.FieldType == implementorType);
    }

    private bool HasFieldOfType(Type type, Type fieldType)
    {
        FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        return fields.Any(field => field.FieldType == fieldType);
    }

    private IEnumerable<Type> GetTypesImplementingInterface<T>()
    {
        return AppDomain.CurrentDomain.GetAssemblies()
                         .SelectMany(assembly => assembly.GetTypes())
                         .Where(type => typeof(T).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);
    }
}
