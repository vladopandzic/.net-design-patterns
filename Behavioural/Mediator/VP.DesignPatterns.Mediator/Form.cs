namespace VP.DesignPatterns.Mediator;

public class Form : IMediator
{
    private readonly List<Colleague> _colleagues = new List<Colleague>();


    public void AddColleague(Colleague colleague)
    {
        _colleagues.Add(colleague);
    }

    public void Send(Colleague sender, string @event)
    {
        foreach (var colleague in _colleagues)
        {
            if (colleague != sender)
            {
                colleague.HandleEvent(@event);
            }
        }
    }
}

