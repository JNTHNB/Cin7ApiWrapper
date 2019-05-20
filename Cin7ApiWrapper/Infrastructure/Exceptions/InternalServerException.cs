using System;

namespace Cin7ApiWrapper.Infrastructure.Exceptions
{
    public class InternalServerException : Exception
    {
        public InternalServerException() { }

        public InternalServerException(string message)
            : base(message)
        {

        }
    }
}
