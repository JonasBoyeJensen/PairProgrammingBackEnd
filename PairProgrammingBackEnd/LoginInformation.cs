using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgrammingBackEnd;

public class LoginInformation
{
    public string Username { get; set; }
    public string Password { get; set; }
    public Role UserRole { get; set; }

    public LoginInformation(string username, string password, Role userRole)
    {
        Username = username;
        Password = password;
        UserRole = userRole;
    }
}
