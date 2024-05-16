namespace VP.DesignPatterns.Mediator;

public class TextBox : Colleague
{
    public string Name { get; set; }

    public TextBox(string name, IMediator mediator) : base(mediator)
    {
        _mediator = mediator;
        Name = name;
    }

    public string Text { get; private set; } = default!;

    public void SetText(string text)
    {
        Text = text;
        _mediator.Send(this, $"Text changed. New text: {text}");

    }

    public override void HandleEvent(string @event)
    {
        Console.WriteLine($"TextBox {Name} handing event {@event}");
    }
}

