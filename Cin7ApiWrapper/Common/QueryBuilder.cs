using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;

namespace Cin7ApiWrapper.Common
{
    internal class QueryBuilder
    {
        public int? Page { get; private set; }
        public int? Rows { get; private set; }
        public string Fields { get; private set; }
        public string Where { get; private set; }
        public string Order { get; private set; }
        public DateTime? ModifiedSince { get; private set; }
        NameValueCollection _parameters;

        public QueryBuilder(int? page = null, int? rows = null, string fields = null, DateTime? modifiedSince = null, string where = null, string order = null)
        {
            if (page.HasValue && page <= 0) throw new ArgumentOutOfRangeException(nameof(page));
            if (rows.HasValue && rows <= 0) throw new ArgumentOutOfRangeException(nameof(rows));

            if (rows > 250)
            {
                throw new ArgumentOutOfRangeException(nameof(rows), $"Cin7 API will not return more than 250 records in a single page request.");
            }

            if (modifiedSince.HasValue && modifiedSince.Value.Kind != DateTimeKind.Utc)
            {
                throw new InvalidOperationException($"{nameof(modifiedSince)} must be UTC");
            }

            Page = page;
            Rows = rows;
            Fields = fields;
            ModifiedSince = modifiedSince;
            Where = where;
            Order = order;
        }

        public string Query
        {
            get
            {
                var collection = BuildCollection();
                return string.Join("&", collection.AllKeys.Select(a => a + "=" + collection[a]).ToArray());
            }
        }

        public string QueryEncoded
        {
            get
            {
                var collection = BuildCollection();
                return string.Join("&", collection.AllKeys.Select(a => a + "=" + WebUtility.UrlEncode(collection[a])).ToArray());
            }
        }

        public void AddParameter(string name, object value)
        {
            if (_parameters == null)
            {
                _parameters = new NameValueCollection();
            }
            _parameters.Add(name, value.ToString());
        }

        public void AddWhereCondition(string condition)
        {
            if (!string.IsNullOrWhiteSpace(Where))
            {
                if (Where.Contains(condition))
                {
                    throw new InvalidOperationException($"Condition ({condition}) already exists in where clause.");
                }

                Where += " and ";
            }
            Where += condition;
        }

        NameValueCollection BuildCollection()
        {
            var collection = new NameValueCollection();

            if (ModifiedSince.HasValue)
            {
                AddWhereCondition(string.Format("modifieddate>'{0:yyyy-MM-ddTHH:mm:ssZ}'", ModifiedSince.Value));
            }

            if (Page.HasValue)
            {
                collection.Add("page", Page.Value);
            }

            if (Rows.HasValue)
            {
                collection.Add("rows", Rows.Value);
            }

            if (!string.IsNullOrWhiteSpace(Fields))
            {
                collection.Add("fields", Fields);
            }

            if (!string.IsNullOrWhiteSpace(Where))
            {
                collection.Add("where", Where);
            }

            if (!string.IsNullOrWhiteSpace(Order))
            {
                collection.Add("order", Order);
            }

            if (_parameters != null)
            {
                collection.Add(_parameters);
            }

            return collection;
        }
    }
}