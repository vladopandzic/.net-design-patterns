namespace VP.DesignPatterns.Flyweight.Tests;

public class FlyweightPatternStructuralTests
{
    [Test]
    public void CharacterFactory_Should_Create_Single_Instance_For_Same_Character()
    {
        // Arrange
        var factory = new CharacterFactory();
        var sprite = new Sprite("sprite.png");

        // Act
        var character1 = factory.GetCharacter("Player", sprite);
        var character2 = factory.GetCharacter("Player", sprite);

        // Assert
        Assert.That(character1, Is.SameAs(character2));
    }

    [Test]
    public void CharacterFactory_Should_Create_Different_Instances_For_Different_Characters()
    {
        // Arrange
        var factory = new CharacterFactory();
        var sprite1 = new Sprite("sprite1.png");
        var sprite2 = new Sprite("sprite2.png");

        // Act
        var character1 = factory.GetCharacter("Player", sprite1);
        var character2 = factory.GetCharacter("Enemy", sprite2);

        // Assert
        Assert.That(character1, Is.Not.SameAs(character2));
    }

    [Test]
    public void Sprite_Should_Be_Created_Only_Once_For_Each_Unique_Sprite_Path()
    {
        // Arrange
        var spritePath = "sprite.png";
        var factory = new CharacterFactory();

        // Act
        var character1 = factory.GetCharacter("Player", new Sprite(spritePath));
        var character2 = factory.GetCharacter("Player", new Sprite(spritePath));

        // Assert
        Assert.That(character1, Is.Not.Null);
        Assert.That(character2, Is.Not.Null);
        Assert.That(character1, Is.TypeOf<Character>());
        Assert.That(character2, Is.TypeOf<Character>());
        Assert.That(((Character)character1).Sprite, Is.SameAs(((Character)character2).Sprite));
    }
}