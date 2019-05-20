using Cin7ApiWrapper.Common;
using System;
using System.Collections.Generic;

namespace Cin7ApiWrapper.Endpoints.Base
{
    public interface ICin7ReadEndpoint<TEndpoint, TModel> where TEndpoint : Cin7ReadEndpoint<TEndpoint, TModel>
    {
        TModel Find(int id);
        TCustomModel Find<TCustomModel>(int id) where TCustomModel : class;
        IEnumerable<TModel> Find(int page = 1, int rows = 50, DateTime? modifiedSince = null, string where = null, string sort = null);
        IEnumerable<TCustomModel> Find<TCustomModel>(int page = 1, int rows = 50, DateTime? modifiedSince = null, string where = null, string sort = null) where TCustomModel : class;
    }

    public abstract class Cin7ReadEndpoint<TEndpoint, TModel> : ICin7ReadEndpoint<TEndpoint, TModel>
        where TEndpoint : Cin7ReadEndpoint<TEndpoint, TModel>
    {
        protected string EndpointUrl { get; set; }
        internal Cin7ApiClient Client { get; }

        internal Cin7ReadEndpoint(Cin7ApiClient client, string endpointUrl)
        {
            Client = client;
            EndpointUrl = endpointUrl;
        }

        public TModel Find(int id)
        {
            return Client.Get<TModel>(EndpointUrl + "/" + id);
        }

        public TCustomModel Find<TCustomModel>(int id) where TCustomModel : class
        {
            var fields = FieldMapper.GetFields(typeof(TCustomModel));
            return Client.Get<TCustomModel>(EndpointUrl + "/" + id, new QueryBuilder(fields: fields));
        }

        public IEnumerable<TModel> Find(int page = 1, int rows = 50, DateTime? modifiedSince = null, string where = null, string sort = null)
        {
            return Client.Get<IEnumerable<TModel>>(EndpointUrl, new QueryBuilder(page, rows, null, modifiedSince, where, sort));
        }

        public IEnumerable<TCustomModel> Find<TCustomModel>(int page = 1, int rows = 50, DateTime? modifiedSince = null, string where = null, string sort = null) where TCustomModel : class
        {
            var fields = FieldMapper.GetFields(typeof(TCustomModel));
            return Client.Get<IEnumerable<TCustomModel>>(EndpointUrl, new QueryBuilder(page, rows, fields, modifiedSince, where, sort));
        }
    }
}
