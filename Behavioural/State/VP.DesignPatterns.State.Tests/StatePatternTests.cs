namespace VP.DesignPatterns.State.Tests;

public class StatePatternTests
{
    private StringWriter sw;

    [SetUp]
    public void Setup()
    {
        sw = new StringWriter();
        Console.SetOut(sw);
    }

    [TearDown]
    public void TearDown()
    {
        sw.Dispose();
    }

    [Test]
    public void TestUnauthorizedStateLogin()
    {
        UserAuthentication userAuth = new UserAuthentication();
        string expectedMessage = "Wrong username or password";

        userAuth.Login("wrongUsername", "wrongPassword");
        string consoleOutput = sw.ToString().Trim();
        Assert.That(consoleOutput, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void TestAuthorizedStateLogin()
    {
        UserAuthentication userAuth = new UserAuthentication();
        string expectedMessage = "Successfully logged in!";

        userAuth.Login("username", "test123");
        string consoleOutput = sw.ToString().Trim();
        Assert.That(consoleOutput, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void TestUnauthorizedStateLogout()
    {
        UserAuthentication userAuth = new UserAuthentication();
        string expectedMessage = "User is not logged in.";

        userAuth.Logout();
        string consoleOutput = sw.ToString().Trim();
        Assert.That(consoleOutput, Is.EqualTo(expectedMessage));
    }

    [Test]
    public void TestAuthorizedStateLogout()
    {
        UserAuthentication userAuth = new UserAuthentication();
        string expectedMessage = "User logged out successfully.";

        // Log in with correct credentials to transition to AuthorizedState
        userAuth.Login("username", "test123");

        sw.GetStringBuilder().Clear();
        userAuth.Logout();
        string consoleOutput = sw.ToString().Trim();
        Assert.That(consoleOutput, Is.EqualTo(expectedMessage));
    }
}