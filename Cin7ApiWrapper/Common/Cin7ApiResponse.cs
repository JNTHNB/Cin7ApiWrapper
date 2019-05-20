using System.Collections.Generic;

namespace Cin7ApiWrapper.Common
{
    internal class Cin7ApiResponse<T>
    {
        public IList<T> Values { get; set; }
        public bool Success { get; set; }
    }
}
