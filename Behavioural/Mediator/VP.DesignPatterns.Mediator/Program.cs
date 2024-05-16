namespace VP.DesignPatterns.Mediator;

internal class Program
{
    static void Main(string[] args)
    {
        Form form = new Form();


        Button button = new Button(form);
        TextBox textBox = new TextBox("Textbox1", form);

        form.AddColleague(textBox);
        form.AddColleague(button);

        textBox.SetText("Hello, Mediator!");
        button.Click();

        Console.ReadKey();
    }
}
