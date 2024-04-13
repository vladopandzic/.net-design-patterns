namespace VP.DesignPatterns.State;

public class UserAuthentication
{
    private State _state;

    public UserAuthentication()
    {
        _state = new UnauthorizedState(this);
    }

    public void ChangeState(State state)
    {
        _state = state;
    }

    public void Login(string username, string password)
    {
        _state.Login(username, password);
    }

    public void Logout()
    {
        _state.Logout();
    }
}
