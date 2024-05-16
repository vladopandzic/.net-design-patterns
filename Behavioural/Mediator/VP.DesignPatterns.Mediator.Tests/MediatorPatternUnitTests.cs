namespace VP.DesignPatterns.Mediator.Tests;

[TestFixture]
public class MediatorPatternUnitTests
{
    [Test]
    public void TextBox_HandlesTextChangeEvent()
    {
        // Arrange
        var mediator = new Form();
        var textBox = new TextBox("TextBox", mediator);
        var button = new Button(mediator);
        mediator.AddColleague(textBox);
        mediator.AddColleague(button);

        // Use StringWriter to capture console output
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Act
            textBox.SetText("Test");

            // Assert
            string consoleOutput = sw.ToString();
            Assert.That(consoleOutput, Contains.Substring($"Button handing event Text changed. New text: Test"));
        }
    }
}

