namespace Cin7ApiWrapper.Infrastructure
{
    internal interface IRateLimiter
    {
        void Wait();
    }
}
