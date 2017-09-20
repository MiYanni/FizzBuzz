using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using FizzBuzz.Extensions;
using FizzBuzz.ObjectOriented;
using FizzBuzz.ObjectOriented.Oop2;
using FizzBuzz.ObjectOriented.Oop3;
using FizzBuzz.ObjectOriented.Oop4;
using FizzBuzz.ObjectOriented.Oop5;

namespace FizzBuzz
{
    // Write a program that prints the numbers from 1 to 100.
    // But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
    // For numbers which are multiples of both three and five print “FizzBuzz”.
    // http://c2.com/cgi/wiki?FizzBuzzTest
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Enumerable.Range(1, 10).Select(v =>
            {
                stopwatch.Restart();
                Enumerable.Range(1, 25).ToList().ForEach(i => PrintNumbers2());
                stopwatch.Stop();
                return String.Format("Pass {0}: {1}", v, stopwatch.ElapsedMilliseconds);
            }).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }

        ////FizzBuzzOop:
        ////Pass 1: 141
        ////Pass 2: 94
        ////Pass 3: 83
        ////Pass 4: 100
        ////Pass 5: 100
        ////Pass 6: 100
        ////Pass 7: 100
        ////Pass 8: 100
        ////Pass 9: 100
        ////Pass 10: 99
        //private static void FizzBuzzOop()
        //{
        //    Enumerable.Range(1, 100).ToList().ForEach(value => value.ToPrintable().Print());
        //}

        ////FizzBuzzOop2:
        ////Pass 1: 129
        ////Pass 2: 86
        ////Pass 3: 81
        ////Pass 4: 79
        ////Pass 5: 80
        ////Pass 6: 79
        ////Pass 7: 82
        ////Pass 8: 82
        ////Pass 9: 80
        ////Pass 10: 80
        //private static void FizzBuzzOop2()
        //{
        //    Enumerable.Range(1, 100).Select(value => new Element2(value)).ForEach(Element2Extensions.Print);
        //}

        ////FizzBuzzOop3:
        ////Pass 1: 134
        ////Pass 2: 83
        ////Pass 3: 85
        ////Pass 4: 76
        ////Pass 5: 79
        ////Pass 6: 83
        ////Pass 7: 78
        ////Pass 8: 77
        ////Pass 9: 82
        ////Pass 10: 78
        //private static void FizzBuzzOop3()
        //{
        //    Enumerable.Range(1, 100).Select(value => new Element3(value)).ForEach(Console.WriteLine);
        //}

        ////FizzBuzzOop4:
        ////Pass 1: 137
        ////Pass 2: 80
        ////Pass 3: 80
        ////Pass 4: 77
        ////Pass 5: 78
        ////Pass 6: 80
        ////Pass 7: 78
        ////Pass 8: 81
        ////Pass 9: 78
        ////Pass 10: 76
        //private static void FizzBuzzOop4()
        //{
        //    Enumerable.Range(1, 100).Select(value => new Element4(value)).ForEach(Console.WriteLine);
        //}

        ////FizzBuzzOop5:
        ////Pass 1: 136
        ////Pass 2: 81
        ////Pass 3: 78
        ////Pass 4: 78
        ////Pass 5: 81
        ////Pass 6: 79
        ////Pass 7: 78
        ////Pass 8: 82
        ////Pass 9: 79
        ////Pass 10: 80
        //private static void FizzBuzzOop5()
        //{
        //    Enumerable.Range(1, 100).Select(value => new Element5(value)).ForEach(Console.WriteLine);
        //}

        // TIME WHILE PLUGGED IN
        private static void PrintNumbers()
        {
            Enumerable.Range(1, 100).ForEach(Console.WriteLine);
        }

        // TIME WHILE PLUGGED IN
        private static void PrintNumbers2()
        {
            for (var i = 1; i <= 100; ++i)
            {
                Console.WriteLine(i);
            }
        }

        //FizzBuzzNormal:
        //Pass 1: 160
        //Pass 2: 119
        //Pass 3: 121
        //Pass 4: 123
        //Pass 5: 122
        //Pass 6: 124
        //Pass 7: 126
        //Pass 8: 118
        //Pass 9: 127
        //Pass 10: 120
        private static void FizzBuzzNormal()
        {
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            for (var value = 1; value <= 100; value++)
            {
                var isBy3 = value % 3 == 0;
                var isBy5 = value % 5 == 0;
                if (isBy3)
                {
                    Console.Write(fizz);
                }
                if (isBy5)
                {
                    Console.Write(buzz);
                }
                if (!isBy3 && !isBy5)
                {
                    Console.Write(value);
                }
                Console.Write(Environment.NewLine);
            }
        }

        //FizzBuzzTernary:
        //Pass 1: 131
        //Pass 2: 98
        //Pass 3: 99
        //Pass 4: 94
        //Pass 5: 95
        //Pass 6: 94
        //Pass 7: 99
        //Pass 8: 95
        //Pass 9: 95
        //Pass 10: 94
        private static void FizzBuzzTernary()
        {
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            const string fizzBuzz = fizz + buzz;
            for (var value = 1; value <= 100; value++)
            {
                var isBy3 = value % 3 == 0;
                var isBy5 = value % 5 == 0;
                Console.WriteLine(
                (isBy3 && isBy5) ? fizzBuzz :
                isBy3 ? fizz :
                isBy5 ? buzz :
                value.ToString(CultureInfo.InvariantCulture));
            }
        }

        //FizzBuzzTernary2:
        //Pass 1: 127
        //Pass 2: 95
        //Pass 3: 80
        //Pass 4: 79
        //Pass 5: 81
        //Pass 6: 82
        //Pass 7: 85
        //Pass 8: 89
        //Pass 9: 81
        //Pass 10: 79
        private static void FizzBuzzTernary2()
        {
            var createFizzBuzz = new Func<int, string>(value =>
                (value % 3 == 0 ? "Fizz" : String.Empty).JoinExt(String.Empty, value % 5 == 0 ? "Buzz" : String.Empty));
            for (var i = 1; i <= 100; Console.WriteLine((createFizzBuzz(i).IsNullOrEmpty() ? i.ToStringInvariant() : createFizzBuzz(i)), ++i)) { }
        }
        
        // NOT TIMED YET.
        private static void FizzBuzzFuncBasic()
        {
            Enumerable.Range(1, 100).Select(i => {
                if (i%3 == 0 && i%5 == 0)
                    return "FizzBuzz";
                if (i%3 == 0)
                    return "Fizz";
                if (i%5 == 0)
                    return "Buzz";
                return i.ToString(CultureInfo.InvariantCulture);
            }).ForEach(i => Debug.WriteLine(i));
        }

        //FizzBuzzInternet:
        //Pass 1: 138
        //Pass 2: 83
        //Pass 3: 79
        //Pass 4: 94
        //Pass 5: 81
        //Pass 6: 82
        //Pass 7: 88
        //Pass 8: 83
        //Pass 9: 86
        //Pass 10: 80
        // http://derreckdean.wordpress.com/2011/05/09/fizzbuzz-in-one-line-c-linq/
        private static void FizzBuzzInternet()
        {
            Enumerable.Range(1, 100).ToList().ForEach(i => Console.WriteLine(
                (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" :
                (i % 5 == 0) ? "Buzz" :
                (i % 3 == 0) ? "Fizz" :
                i.ToString(CultureInfo.InvariantCulture)));
        }

        //private static readonly Func<int, int, bool> DivisibleBy = (v, d) => (v % d) == 0;
    }

    public static class Functional
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

    //public static class NumericExtensions
    //{
    //    public static bool IsDivisibleBy(this int value, int divisor)
    //    {
    //        return (value % divisor) == 0;
    //    }

    //    public static string ToStringInvariant(this int value)
    //    {
    //        return value.ToString(CultureInfo.InvariantCulture);
    //    }
    //}

    //public static class EnumerableExtensions
    //{
    //    public static IEnumerable<TSource> Replace<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TSource> replacer)
    //    {
    //        return source.Select(s => predicate(s) ? replacer(s) : s);
    //    }

    //    public static IEnumerable<TSource> Replace<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate, Func<TSource, int, TSource> replacer)
    //    {
    //        return source.Select((s, i) => predicate(s, i) ? replacer(s, i) : s);
    //    }

    //    public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
    //    {
    //        foreach (var value in source)
    //        {
    //            action(value);
    //        }
    //    }
    //}

    //public static class StringExtensions
    //{
    //    public static bool IsNullOrEmpty(this string value)
    //    {
    //        return String.IsNullOrEmpty(value);
    //    }

    //    public static string IfNullOrEmptyThenDefault(this string value, string defaultValue)
    //    {
    //        return value.IsNullOrEmpty() ? defaultValue : value;
    //    }

    //    public static string JoinExt(this string value, string separator, params string[] values)
    //    {
    //        var combinedList = values.ToList();
    //        combinedList.Insert(0, value);
    //        return String.Join(separator, combinedList);
    //    }
    //}

    public delegate void ActionOut<T>(out T obj);

    public static class MethodExtensions
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
    public static class MethodExtensions2
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
            withCache = ((Func<int, int>)Next).AddCaching<int,int>();
            Func<int,int> withCache2 = ((Func <int, int>)Next).AddCaching();
        }

        public static int Next(int n)
        {
            Console.WriteLine("Called Next(" + n + ")");
            return n + 1;
        }
    }
}