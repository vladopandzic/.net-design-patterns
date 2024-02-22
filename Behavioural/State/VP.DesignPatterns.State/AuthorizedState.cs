namespace VP.DesignPatterns.State;
public class AuthorizedState : State
{
    readonly UserAuthentication _userAuthentication;
    public AuthorizedState(UserAuthentication userAuthentication)
    {
        _userAuthentication = userAuthentication;
    }

    public override void Login(string username, string password)
    {
        Console.WriteLine("User is already logged in.");

    }

    public override void Logout()
    {
        _userAuthentication.ChangeState(new UnauthorizedState(_userAuthentication));
        Console.WriteLine("User logged out successfully.");

    }

}
