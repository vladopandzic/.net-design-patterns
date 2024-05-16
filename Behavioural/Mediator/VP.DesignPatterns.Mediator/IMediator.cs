namespace VP.DesignPatterns.Mediator;

public interface IMediator
{
    void Send(Colleague sender, string @event);
}

