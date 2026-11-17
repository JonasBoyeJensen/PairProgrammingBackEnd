namespace PairProgrammingBackEnd.UnitTests;

[TestClass]
public class LoginTestIsNull
{
    [TestMethod]
    [DataRow("invalidUser", "invalidPassword")]
    [DataRow("user1", "wrongPassword")]
    public void TestInvalidCredentials_ReturnsNull(string username, string password)
    {
        // Arrange
        var authenticator = new Authenticator();

        // Act
        Role? testRole = authenticator.Authenticate(username, password);

        // Assert
        Assert.IsNull(testRole);
    }
}
