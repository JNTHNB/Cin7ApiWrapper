using System;

namespace Cin7ApiWrapper.Infrastructure.Exceptions
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException() { }

        public ForbiddenException(string message)
            : base(message)
        {

        }
    }
}
