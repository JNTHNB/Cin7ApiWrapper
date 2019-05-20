using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Endpoints
{
    public class QuotesEndpoint : Cin7Endpoint<QuotesEndpoint, Quote>
    {
        internal QuotesEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/Quotes")
        {

        }

        public CreateResult Create(Quote item, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Create(item);
        }

        public CreateBatchResult Create(IEnumerable<Quote> items, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Create(items);
        }

        public UpdateResult Update(Quote item, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Update(item);
        }

        public UpdateBatchResult Update(IEnumerable<Quote> items, bool loadboms)
        {
            Parameters.Add("loadboms", loadboms.ToString());
            return Update(items);
        }
    }
}
