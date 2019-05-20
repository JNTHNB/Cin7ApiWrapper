using System;

namespace Cin7ApiWrapper.Infrastructure.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException() { }

        public BadRequestException(string message)
            : base(message)
        {

        }
    }
}
