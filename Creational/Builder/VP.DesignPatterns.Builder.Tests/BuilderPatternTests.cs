namespace VP.DesignPatterns.Builder.Tests;
public class BuilderPatternTests
{
    [Test]
    public void BuildComputer_Should_Print_Correctly()
    {
        // Arrange
        var expectedOutput = "Computer with Intel Core i9 CPU, NVIDIA GeForce RTX 3080 GPU, 32GB RAM, and 1GB storage.";
        var computerBuilder = new GamingComputerBuilder();

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            var computer = computerBuilder
                 .SetCPU("Intel Core i9")
                 .BuildRAM(32)
                 .BuildStorage(1)
                 .BuildGPU("NVIDIA GeForce RTX 3080")
                 .Build();


            computer.Display();

            var actualOutput = sw.ToString().Trim();

            // Assert
            Assert.That(actualOutput, Is.EqualTo(expectedOutput), "Computer should be built correctly.");
        }
    }
}
