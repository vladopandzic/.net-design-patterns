namespace VP.DesignPatterns.State;

public class UnauthorizedState : State
{
    readonly UserAuthentication _userAuthentication;

    public UnauthorizedState(UserAuthentication userAuthentication)
    {
        _userAuthentication = userAuthentication;
    }

    public override void Login(string username, string password)
    {
        if (username == "username" && password == "test123")
        {
            _userAuthentication.ChangeState(new AuthorizedState(_userAuthentication));
            Console.WriteLine("Successfully logged in!");
        }
        else
        {
            Console.WriteLine("Wrong username or password");
        }
    }

    public override void Logout()
    {
        Console.WriteLine("User is not logged in.");
    }
}

