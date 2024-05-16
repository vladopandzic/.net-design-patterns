using NSubstitute;

namespace VP.DesignPatterns.Mediator.Tests;

[TestFixture]
public class MediatorDesignPatternStructuralTests
{
    [Test]
    public void TextBox_SetText_ShouldNotifyMediator()
    {
        // Arrange
        var mediator = Substitute.For<IMediator>();
        var textBox = new TextBox("textbox1", mediator);
        string newText = "Test Text";

        // Act
        textBox.SetText(newText);

        // Assert
        mediator.Received().Send(textBox, $"Text changed. New text: {newText}");
    }

    [Test]
    public void Button_Click_ShouldNotifyMediator()
    {
        // Arrange
        var mediator = Substitute.For<IMediator>();
        var button = new Button(mediator);

        // Act
        button.Click();

        // Assert
        mediator.Received().Send(button, "Click event");
    }

    [Test]
    public void Mediator_ForwardsTextChangeToOtherTextBoxes()
    {
        // Arrange
        var mediator = new Form();
        var textBox1 = new TextBox("TextBox1", mediator);
        var textBox2 = new TextBox("TextBox2", mediator);
        var button = new Button(mediator);

        mediator.AddColleague(textBox1);
        mediator.AddColleague(textBox2);
        mediator.AddColleague(textBox2);

        // Use StringWriter to capture console output
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Act
            button.Click();

            // Assert
            string expectedOutput1 = $"TextBox {textBox1.Name} handing event Click event";
            string expectedOutput2 = $"TextBox {textBox2.Name} handing event Click event";

            string consoleOutput = sw.ToString();
            Assert.That(consoleOutput, Contains.Substring(expectedOutput1));
            Assert.That(consoleOutput, Contains.Substring(expectedOutput2));
        }
    }
}