using System.Net;

namespace Cin7ApiWrapper.Infrastructure
{
    internal class Response<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Result { get; set; }
        public string Error { get; set; }
    }
}