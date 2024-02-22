using System.Reflection;

namespace VP.DesignPatterns.Singleton.Tests;

public class MySingletonTests
{
    [Test]
    [NonParallelizable]
    public void Singleton_Instance_IsNotNull()
    {
        // Arrange
        var singletonType = typeof(MySingleton);
        var instanceProperty = singletonType.GetProperty("Instance", BindingFlags.Static | BindingFlags.Public);

        // Act
        var instance = instanceProperty?.GetValue(null);

        // Assert
        Assert.IsNotNull(instance);
        Assert.IsNotNull(instance, "Singleton instance should not be null.");
    }

    [Test]
    [NonParallelizable]
    public void Singleton_Returns_Same_Instance()
    {
        // Arrange
        var singletonType = typeof(MySingleton);
        var instanceProperty = singletonType.GetProperty("Instance", BindingFlags.Static | BindingFlags.Public);

        // Act
        var instance1 = instanceProperty?.GetValue(null);
        var instance2 = instanceProperty?.GetValue(null);

        // Assert
        Assert.That(instance1, Is.SameAs(instance2), "Singleton should return the same instance.");
    }

    [Test]
    [NonParallelizable]
    public void Singleton_Constructor_IsPrivate()
    {
        // Arrange
        var constructors = typeof(MySingleton).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
        var privateConstructors = typeof(MySingleton).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);

        // Assert
        Assert.That(privateConstructors.Length, Is.EqualTo(1), "Singleton constructor should be private constructors.");
        Assert.That(constructors.Length, Is.EqualTo(0), "Singleton constructor should be private.");
    }
}