using System;
using System.Collections.Generic;

namespace FizzBuzz.Other
{
    internal delegate void ActionOut<T>(out T obj);

    internal static class MethodExtensions
    {
        public static T ReturnOut<T>(this ActionOut<T> method)
        {
            method(out T result);
            return result;
        }

        public static void Test()
        {
            var test = ReturnOut<int>(TestMethod);
            var test2 = ((ActionOut<int>)TestMethod).ReturnOut();
        }

        private static void TestMethod(out int cake)
        {
            cake = 42;
        }
    }

    //https://stackoverflow.com/questions/22814262/c-sharp-extension-method-for-a-method-group/46330225#46330225
    internal static class MethodExtensions2
    {
        public static Func<TKey, TVal> AddCaching<TKey, TVal>(this Func<TKey, TVal> fetcher)
        {
            var cache = new Dictionary<TKey, TVal>();
            return k =>
            {
                if (!cache.ContainsKey(k)) cache[k] = fetcher(k);
                return cache[k];
            };
        }

        public static void Test()
        {
            // Works
            var withCache = ((Func<int, int>)Next).AddCaching();
            withCache = new Func<int, int>(Next).AddCaching();
            withCache = AddCaching<int, int>(Next);

            // Doesn't work :(
            withCache = ((Func<int, int>)Next).AddCaching<int, int>();
            Func<int, int> withCache2 = ((Func<int, int>)Next).AddCaching();
        }

        public static int Next(int n)
        {
            Console.WriteLine("Called Next(" + n + ")");
            return n + 1;
        }
    }
}
