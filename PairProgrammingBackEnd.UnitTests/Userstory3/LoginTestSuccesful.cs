namespace PairProgrammingBackEnd.UnitTests;

[TestClass]
public class LoginTestSuccesful
{
    [TestMethod]
    [DataRow("user1", "password1", Role.Admin)]
    [DataRow("user2", "password2", Role.User)]
    public void SuccessfulLogin_ReturnsOk(string username, string password, Role role)
    {
        // Arrange
        var authenticator = new Authenticator();

        // Act
        Role? testRole = authenticator.Authenticate(username, password);

        // Assert
        Assert.AreEqual(role, testRole);
    }
}
