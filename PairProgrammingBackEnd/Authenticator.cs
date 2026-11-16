using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgrammingBackEnd;

public enum Role
{
    Admin,
    User
}

public class Authenticator
{
    public Dictionary<string, LoginInformation> Users { get; set; } = new Dictionary<string, LoginInformation> { };

    public Authenticator()
    {
        Users.Add("user1", new LoginInformation("user1", "password1", Role.Admin));
        Users.Add("user2", new LoginInformation("user2", "password2", Role.User));
    }

    public Role? Authenticate(string username, string password)
    {
        if (Users.ContainsKey(username) && Users[username].Password == password)
        {
            return Users[username].UserRole;
        }
        return null;
    }


}
