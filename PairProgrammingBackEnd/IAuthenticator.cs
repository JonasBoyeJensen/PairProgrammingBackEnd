namespace PairProgrammingBackEnd
{
    public interface IAuthenticator
    {
        Dictionary<string, LoginInformation> Users { get; set; }

        Role? Authenticate(string username, string password);
    }
}