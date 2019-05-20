using System;

namespace Cin7ApiWrapper.Infrastructure.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() { }

        public NotFoundException(string message)
            : base(message)
        {

        }
    }
}
