using Cin7ApiWrapper.Infrastructure;
using Cin7ApiWrapper.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Cin7ApiWrapper.Common
{
    internal class Cin7ApiClient
    {
        static HttpClient _client;
        readonly IRateLimiter _rateLimiter;
        readonly IUser _userConnection;
        readonly ICin7ApiSettings _cin7ApiSettings;
        const string MediaTypeJson = "application/json";

        public string UserAgent
        {
            set
            {
                _client.DefaultRequestHeaders.UserAgent.Clear();
                _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue(value)));
            }
        }

        public Cin7ApiClient(ICin7ApiSettings cin7ApiSettings, IUser userConnection, IRateLimiter rateLimiter)
        {
            _userConnection = userConnection ?? throw new ArgumentNullException(nameof(userConnection));
            _rateLimiter = rateLimiter ?? throw new ArgumentNullException(nameof(rateLimiter));
            _cin7ApiSettings = cin7ApiSettings ?? throw new ArgumentNullException(nameof(cin7ApiSettings));

            _client = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            });

            _client.BaseAddress = new Uri(_cin7ApiSettings.BaseUrl);
            _client.DefaultRequestHeaders.UserAgent.Add(ProductInfoHelper.GetUserAgentHeaderValue());

            var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", _userConnection.Username, _userConnection.Password)));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
        }

        public TResult Get<TResult>(string endpoint, QueryBuilder query = null)
        {

            if (_rateLimiter != null)
            {
                _rateLimiter.Wait();
            }

            var uri = new UriBuilder(_cin7ApiSettings.BaseUrl)
            {
                Path = endpoint
            };

            if (query != null)
            {
                uri.Query = query.Query;
            }

            try
            {
                var response = _client.GetAsync(uri.Uri).Result;

                return new Response<TResult>(response).Result;
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    new WebExceptionHandler((HttpWebResponse)ex.Response);
                }

                throw;
            }
        }

        public IEnumerable<ResultItem> Post<T>(string endpoint, IEnumerable<T> records, NameValueCollection parameters)
        {
            if (_rateLimiter != null)
            {
                _rateLimiter.Wait();
            }

            var uri = new UriBuilder(_client.BaseAddress)
            {
                Path = endpoint,
                Query = parameters.ToQueryString()
            };

            try
            {
                using (var content = new StringContent(JsonConvert.SerializeObject(records), Encoding.UTF8, MediaTypeJson))
                {
                    var httpresponse = _client.PostAsync(uri.Uri, content).Result;
                    return new Response<IEnumerable<ResultItem>>(httpresponse).Result;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    new WebExceptionHandler((HttpWebResponse)ex.Response);
                }

                throw;
            }
        }

        public IEnumerable<ResultItem> Put<T>(string endpoint, IEnumerable<T> records, NameValueCollection parameters)
        {

            if (_rateLimiter != null)
            {
                _rateLimiter.Wait();
            }

            var uri = new UriBuilder(_client.BaseAddress)
            {
                Path = endpoint,
                Query = parameters.ToQueryString()
            };

            try
            {
                using (var content = new StringContent(JsonConvert.SerializeObject(records), Encoding.UTF8, MediaTypeJson))
                {
                    var httpresponse = _client.PutAsync(uri.Uri, content).Result;
                    return new Response<IEnumerable<ResultItem>>(httpresponse).Result;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    new WebExceptionHandler((HttpWebResponse)ex.Response);
                }

                throw;
            }
        }
    }
}