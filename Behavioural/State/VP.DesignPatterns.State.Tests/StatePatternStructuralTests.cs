using System.Reflection;

namespace VP.DesignPatterns.State.Tests;

public class StatePatternStructuralTests
{
    [Test]
    public void TestInitialState()
    {
        UserAuthentication userAuth = new UserAuthentication();
        Assert.That(GetState(userAuth), Is.TypeOf<UnauthorizedState>());
    }

    [Test]
    public void TestLoginTransitionToAuthorizedState()
    {
        UserAuthentication userAuth = new UserAuthentication();
        userAuth.Login("username", "test123");
        Assert.That(GetState(userAuth), Is.TypeOf<AuthorizedState>());
    }

    [Test]
    public void TestLoginWithInvalidCredentialsDoesNotChangeState()
    {
        UserAuthentication userAuth = new UserAuthentication();
        userAuth.Login("wrongUsername", "wrongPassword");
        Assert.That(GetState(userAuth), Is.TypeOf<UnauthorizedState>());
    }

    [Test]
    public void TestLogoutFromAuthorizedState()
    {
        UserAuthentication userAuth = new UserAuthentication();
        userAuth.Login("username", "test123");
        userAuth.Logout();
        Assert.That(GetState(userAuth), Is.TypeOf<UnauthorizedState>());
    }

    private State GetState(UserAuthentication userAuth)
    {
        Type userAuthType = typeof(UserAuthentication);
        FieldInfo? stateField = userAuthType.GetField("_state", BindingFlags.NonPublic | BindingFlags.Instance);
        return (State?)stateField?.GetValue(userAuth)!;
    }
}
