using Cin7ApiWrapper.Infrastructure;
using NUnit.Framework;
using System.Diagnostics;

namespace Tests
{
    [TestFixture]
    public class RateLimiterTests
    {
        [Test]
        public void TestRateLimiter_NoMoreThan1RequestPerSecond()
        {
            int requests = 3;

            var sw = new Stopwatch();
            sw.Start();

            var rl = new RateLimiter();

            for (int i = requests; i > 0; i--)
            {
                rl.Wait();
            }

            sw.Stop();

            long expected = (requests - 1) * 1000;
            long actual = sw.ElapsedMilliseconds;

            Assert.GreaterOrEqual(actual, expected);
        }
    }
}
