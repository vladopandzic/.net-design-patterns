namespace VP.DesignPatterns.State;
public abstract class State
{
    public abstract void Login(string username, string password);

    public abstract void Logout();


}
