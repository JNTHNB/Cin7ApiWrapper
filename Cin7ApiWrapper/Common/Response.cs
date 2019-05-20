using Cin7ApiWrapper.Infrastructure;
using Cin7ApiWrapper.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net;
using System.Net.Http;

namespace Cin7ApiWrapper.Common
{
    internal class Response<TResult>
    {
        internal Response(HttpResponseMessage httpResponseMessage)
        {
            string result = httpResponseMessage.Content.ReadAsStringAsync().Result;

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            StatusCode = httpResponseMessage.StatusCode;

            if (StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    Result = JsonConvert.DeserializeObject<TResult>(result, settings);
                }
                catch
                {
                    throw new NotSupportedException($"Unable to deserialize object of type {typeof(TResult)}");
                }
            }
            else
            {
                string message = null;
                try
                {
                    var error = JsonConvert.DeserializeObject<ErrorMessage>(result, settings);

                    if (error != null)
                    {
                        message = error.Message;
                    }
                }
                catch (JsonSerializationException)
                {
                    // Note throttle limit errors are not in JSON form.
                    message = result.Trim(new char[] { '"' });
                }

                new WebExceptionHandler(StatusCode, message);
            }
        }

        public TResult Result { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }
    }
}
