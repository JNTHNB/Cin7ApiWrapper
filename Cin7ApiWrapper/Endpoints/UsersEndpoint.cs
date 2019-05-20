using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Models;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Endpoints
{
    public class UsersEndpoint
    {
        const string _endpoint = "/api/v1/Users";

        internal Cin7ApiClient Client { get; private set; }

        internal UsersEndpoint(Cin7ApiClient client)
        {
            Client = client;
        }

        public User Find(int id)
        {
            return Client.Get<User>(_endpoint + "/" + id);
        }

        public IEnumerable<User> List()
        {
            return Client.Get<IEnumerable<User>>(_endpoint);
        }
    }
}
