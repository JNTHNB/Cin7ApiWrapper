using Cin7ApiWrapper.Infrastructure.Exceptions;
using System;
using System.IO;
using System.Net;

namespace Cin7ApiWrapper.Infrastructure
{
    internal class WebExceptionHandler
    {
        public WebExceptionHandler(HttpWebResponse response)
        {
            string message;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                message = sr.ReadToEnd();
            }

            Throw(response.StatusCode, message);
        }

        public WebExceptionHandler(HttpStatusCode httpStatusCode, string message)
        {
            Throw(httpStatusCode, message);
        }

        void Throw(HttpStatusCode httpStatusCode, string message)
        {
            switch ((int)httpStatusCode)
            {
                case 400:
                    throw new BadRequestException(message);
                case 401:
                    throw new UnauthorizedException(message);
                case 403:
                    throw new ForbiddenException(message);
                case 404:
                    throw new NotFoundException(message);
                case 429:
                    throw new RateExceededException(message);
                case 500:
                    throw new InternalServerException(message);
                default:
                    throw new Exception($"Error {(int)httpStatusCode} {httpStatusCode}");
            }
        }
    }
}
