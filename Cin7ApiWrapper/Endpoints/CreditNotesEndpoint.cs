using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class CreditNotesEndpoint : Cin7ReadEndpoint<CreditNotesEndpoint, CreditNote>
    {
        internal CreditNotesEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/CreditNotes")
        {

        }
    }
}
