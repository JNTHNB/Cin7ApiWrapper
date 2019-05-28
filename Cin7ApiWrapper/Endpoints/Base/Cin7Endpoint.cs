using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Cin7ApiWrapper.Endpoints.Base
{
    public interface ICin7Endpoint<TEndpoint, TModel> where TEndpoint : Cin7Endpoint<TEndpoint, TModel>
    {
        CreateResult Create(TModel item);
        UpdateResult Update(TModel item);
        CreateBatchResult Create(IEnumerable<TModel> batch);
        UpdateBatchResult Update(IEnumerable<TModel> batch);
    }

    public abstract class Cin7Endpoint<TEndpoint, TModel> : Cin7ReadEndpoint<TEndpoint, TModel>, ICin7Endpoint<TEndpoint, TModel>
        where TEndpoint : Cin7Endpoint<TEndpoint, TModel>
    {
        protected NameValueCollection Parameters = new NameValueCollection();

        internal Cin7Endpoint(Cin7ApiClient client, string endpoint)
            : base(client, endpoint)
        {

        }

        public CreateResult Create(TModel item)
        {
            if (item == null)
            {
                throw new ArgumentException("Unable to perform create because the item is null.");
            }

            try
            {
                return new CreateResult(Create(new[] { item }).Results.Single());
            }
            finally
            {
                Parameters.Clear();
            }
        }

        public CreateBatchResult Create(IEnumerable<TModel> items)
        {
            if (items == null || items.Count() == 0)
            {
                throw new ArgumentException("Unable to perform create because the batch is empty or null.");
            }

            try
            {
                return new CreateBatchResult(Client.Post(EndpointUrl, items, Parameters));
            }
            finally
            {
                Parameters.Clear();
            }
        }

        public UpdateResult Update(TModel item)
        {
            if (item == null)
            {
                throw new ArgumentException("Unable to perform update because the item is null.");
            }

            try
            {
                return new UpdateResult(Update(new[] { item }).Results.Single());
            }
            finally
            {
                Parameters.Clear();
            }
        }

        public UpdateBatchResult Update(IEnumerable<TModel> items)
        {
            if (items == null || items.Count() == 0)
            {
                throw new ArgumentException("Unable to perform update because the batch is empty or null.");
            }

            try
            {
                return new UpdateBatchResult(Client.Put(EndpointUrl, items, Parameters));
            }
            finally
            {
                Parameters.Clear();
            }
        }
    }
}
