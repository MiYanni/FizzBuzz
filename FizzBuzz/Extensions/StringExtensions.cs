using System;
using System.Linq;

namespace FizzBuzz.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return String.IsNullOrEmpty(value);
        }

        public static string IfNullOrEmptyThenDefault(this string value, string defaultValue)
        {
            return value.IsNullOrEmpty() ? defaultValue : value;
        }

        public static string JoinExt(this string value, string separator, params string[] values)
        {
            var combinedList = values.ToList();
            combinedList.Insert(0, value);
            return String.Join(separator, combinedList);
        }
    }
}
