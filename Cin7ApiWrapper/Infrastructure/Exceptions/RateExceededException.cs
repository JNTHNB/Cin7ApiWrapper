using System;

namespace Cin7ApiWrapper.Infrastructure.Exceptions
{
    public class RateExceededException : Exception
    {
        public RateExceededException() { }

        public RateExceededException(string message)
            : base(message)
        {

        }
    }
}
