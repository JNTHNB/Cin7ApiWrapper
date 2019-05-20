using System.Collections.Generic;

namespace Cin7ApiWrapper.Models
{
    public sealed class CreateBatchResult
    {
        public IEnumerable<ResultItem> Results { get; }

        internal CreateBatchResult(IEnumerable<ResultItem> results)
        {
            Results = results;
        }
    }

    public sealed class UpdateBatchResult
    {
        public IEnumerable<ResultItem> Results { get; }

        internal UpdateBatchResult(IEnumerable<ResultItem> results)
        {
            Results = results;
        }
    }

    public sealed class ResultItem : ResultItemBase
    {
        public int Index { get; set; }
    }

    public abstract class ResultItemBase
    {
        public int? Id { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }

    public sealed class CreateResult : ResultItemBase
    {
        internal CreateResult(ResultItem item)
        {
            Id = item.Id;
            Success = item.Success;
            Errors = item.Errors;
        }
    }

    public sealed class UpdateResult : ResultItemBase
    {
        internal UpdateResult(ResultItem item)
        {
            Id = item.Id;
            Success = item.Success;
            Errors = item.Errors;
        }
    }
}