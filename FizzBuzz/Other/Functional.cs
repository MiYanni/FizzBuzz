using System;

namespace FizzBuzz.Other
{
    internal static class Functional
    {
        public static void ForLoop<T>(T initializer, Func<T, bool> condition, Func<T, T> iterator, Action<T> body)
        {
            for (var i = initializer; condition(i); i = iterator(i))
            {
                body(i);
            }
        }

        public static void ForLoop<T>(T initializer, Func<T, bool> condition, Func<T, T> iterator, Func<T, bool> body)
        {
            for (var i = initializer; condition(i); i = iterator(i))
            {
                if (!body(i)) break;
            }
        }
    }
}
