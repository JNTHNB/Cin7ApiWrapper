using System;
using System.Threading;

namespace Cin7ApiWrapper.Infrastructure
{
    internal class RateLimiter : IRateLimiter
    {
        DateTime? _lastRequest;

        public RateLimiter()
        {
        }

        public void Wait()
        {
            if (_lastRequest.HasValue)
            {
                Thread.Sleep(1000);
            }

            _lastRequest = DateTime.UtcNow;
        }
    }
}
