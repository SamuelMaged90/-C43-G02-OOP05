
using System.Security.Principal;

namespace Task.Question02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public BasicAuthenticationService(string username, string password,string Role)
        {
            Name = username;
            Password = password;
            this.Role = Role;
        }
        public bool AuthenticateUser(string username, string password)
        {
            return username == Name && password == Password;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == Name && Role == role;
        }
    }
}
