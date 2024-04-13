using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace VP.DesignPatterns.Flyweight.Tests;

public class FlyweightPatternTests
{
    private StringWriter _consoleOutput;
    private TextWriter _originalConsoleOutput;

    [SetUp]
    public void Setup()
    {
        _consoleOutput = new StringWriter();
        _originalConsoleOutput = Console.Out;
        Console.SetOut(_consoleOutput);
        _consoleOutput.GetStringBuilder().Clear(); // Clear buffer before each test

    }

    [TearDown]
    public void Cleanup()
    {
        _consoleOutput.Dispose();
        Console.SetOut(_originalConsoleOutput);
    }

    [Test]
    public void Display_Method_Should_Output_Correct_Information()
    {
        // Arrange
        var characterName = "Player";
        var spritePath = "player_sprite.png";
        var sprite = new Sprite(spritePath);
        var character = new Character(characterName, sprite);

        // Act
        character.Display(10, 20);

        // Assert
        Assert.That(_consoleOutput.ToString(), Contains.Substring($"Displaying {characterName} at position (10, 20) with sprite '{spritePath}'"));
    }

    [Test]
    public void Render_Method_Should_Display_Characters_With_Correct_Sprites()
    {
        // Arrange
        var game = new Game();
        var playerSprite = new Sprite("player_sprite.png");
        var enemySprite = new Sprite("enemy_sprite.png");

        game.AddCharacter("Player", 10, 20, playerSprite);
        game.AddCharacter("Enemy", 30, 40, enemySprite);

        // Act
        game.Render();

        // Assert
        Assert.That(_consoleOutput.ToString(), Contains.Substring($"Displaying Player at position (10, 20) with sprite '{playerSprite.ImagePath}'"));
        Assert.That(_consoleOutput.ToString(), Contains.Substring($"Displaying Enemy at position (30, 40) with sprite '{enemySprite.ImagePath}'"));
    }
}
