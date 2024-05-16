namespace VP.DesignPatterns.Mediator;

public abstract class Colleague
{
    protected IMediator _mediator = default!;

    public Colleague(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void HandleEvent(string @event);
}

