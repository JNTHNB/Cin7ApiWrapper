using System;

namespace Cin7ApiWrapper.Infrastructure
{
    public class ApiUser : IUser
    {
        public ApiUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException(nameof(username));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException(nameof(password));
            }

            Username = username;
            Password = password;
        }

        public string Username { get; }
        public string Password { get; }
    }
}
