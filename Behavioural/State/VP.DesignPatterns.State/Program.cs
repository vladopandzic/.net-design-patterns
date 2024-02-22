namespace VP.DesignPatterns.State;

internal class Program
{
    static void Main(string[] args)
    {
        UserAuthentication userAuth = new UserAuthentication();

        // Attempt to log in with incorrect credentials
        userAuth.Login("wrongUsername", "wrongPassword");

        // Attempt to log in with correct credentials
        userAuth.Login("username", "test123");

        // Attempt to log in again (already logged in)
        userAuth.Login("username", "test123");

        // Logout
        userAuth.Logout();
    }
}
