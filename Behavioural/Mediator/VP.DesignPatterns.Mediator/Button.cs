namespace VP.DesignPatterns.Mediator;

public class Button : Colleague
{
    public Button(IMediator mediator) : base(mediator)
    {

    }

    public void Click()
    {
        _mediator.Send(this, "Click event");
    }

    public override void HandleEvent(string @event)
    {
        Console.WriteLine($"Button handing event {@event}");
    }
}

