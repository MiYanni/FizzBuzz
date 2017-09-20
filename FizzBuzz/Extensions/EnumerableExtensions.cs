using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TSource> Replace<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TSource> replacer)
        {
            return source.Select(s => predicate(s) ? replacer(s) : s);
        }

        public static IEnumerable<TSource> Replace<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, Func<TSource, int, TSource> replacer)
        {
            return source.Select((s, i) => predicate(s, i) ? replacer(s, i) : s);
        }

        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            foreach (var value in source)
            {
                action(value);
            }
        }
    }
}
