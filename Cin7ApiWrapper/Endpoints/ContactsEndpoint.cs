using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class ContactsEndpoint : Cin7Endpoint<ContactsEndpoint, Contact>
    {
        internal ContactsEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/Contacts")
        {

        }
    }
}
