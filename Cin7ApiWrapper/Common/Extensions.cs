using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Cin7ApiWrapper.Common
{
    internal static class Extensions
    {
        public static string JoinFormat<T>(this IEnumerable<T> list, string separator, string formatString)
        {
            formatString = string.IsNullOrWhiteSpace(formatString) ? "{0}" : formatString;
            return string.Join(separator,
                                 list.Select(item => string.Format(formatString, item)));
        }

        public static void Add(this NameValueCollection collection, string name, int value)
        {
            collection.Add(name, value.ToString());
        }

        public static string ToQueryString(this NameValueCollection collection)
        {
            if (collection == null) return string.Empty;

            var sb = new StringBuilder();

            foreach (string key in collection.Keys)
            {
                if (string.IsNullOrWhiteSpace(key)) continue;

                string[] values = collection.GetValues(key);
                if (values == null) continue;

                foreach (string value in values)
                {
                    sb.Append(sb.Length > 0 ? "&" : "");
                    sb.AppendFormat("{0}={1}", Uri.EscapeDataString(key), Uri.EscapeDataString(value));
                }
            }

            return sb.ToString();
        }
    }
}
