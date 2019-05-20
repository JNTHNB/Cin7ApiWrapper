using System;

namespace Cin7ApiWrapper.Infrastructure.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException() { }

        public UnauthorizedException(string message)
            : base(message)
        {

        }
    }
}
