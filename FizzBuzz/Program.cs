using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;
using FizzBuzz.ObjectOriented;

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
                Enumerable.Range(1, 25).ToList().ForEach(i => FizzBuzzTernary());
                stopwatch.Stop();
                return String.Format("Pass {0}: {1}", v, stopwatch.ElapsedMilliseconds);
            }).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }

        //FizzBuzz1:
        //Pass 1: 162
        //Pass 2: 80
        //Pass 3: 86
        //Pass 4: 97
        //Pass 5: 79
        //Pass 6: 83
        //Pass 7: 87
        //Pass 8: 84
        //Pass 9: 83
        //Pass 10: 82
        private static void FizzBuzz1()
        {
            Enumerable.Range(1, 100)
                .Replace(v => v.IsDivisibleBy(15), v => -11)
                .Replace(v => v.IsDivisibleBy(5), v => -7)
                .Replace(v => v.IsDivisibleBy(3), v => -2)
                .Select(v => v.ToString(CultureInfo.InvariantCulture))
                .Replace(s => s.Equals("-2"), s => "Fizz")
                .Replace(s => s.Equals("-7"), s => "Buzz")
                .Replace(s => s.Equals("-11"), s => "FizzBuzz")
                .ToList().ForEach(Console.WriteLine);
        }

        //FizzBuzz2:
        //Pass 1: 161
        //Pass 2: 83
        //Pass 3: 81
        //Pass 4: 80
        //Pass 5: 79
        //Pass 6: 82
        //Pass 7: 85
        //Pass 8: 78
        //Pass 9: 79
        //Pass 10: 82
        private static void FizzBuzz2()
        {
            Enumerable.Range(1, 100)
                .Select(v => new { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Fizz") })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Buzz") })
                .Replace(vn => String.IsNullOrEmpty(vn.Name), vn => new { vn.Value, Name = vn.Value.ToString(CultureInfo.InvariantCulture) })
                .Select(vn => vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }

        //FizzBuzz3:
        //Pass 1: 152
        //Pass 2: 86
        //Pass 3: 81
        //Pass 4: 82
        //Pass 5: 99
        //Pass 6: 85
        //Pass 7: 87
        //Pass 8: 81
        //Pass 9: 91
        //Pass 10: 91
        private static void FizzBuzz3()
        {
            (new int[100])
                .Select((v, i) => new { Value = i + 1, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Fizz") })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Buzz") })
                .Replace(vn => String.IsNullOrEmpty(vn.Name), vn => new { vn.Value, Name = vn.Value.ToString(CultureInfo.InvariantCulture) })
                .Select(vn => vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }

        private sealed class ValueName
        {
            public int Value { get; set; }

            public string Name { get; set; }
        }

        //FizzBuzz4:
        //Pass 1: 175
        //Pass 2: 89
        //Pass 3: 83
        //Pass 4: 82
        //Pass 5: 84
        //Pass 6: 86
        //Pass 7: 86
        //Pass 8: 86
        //Pass 9: 88
        //Pass 10: 85
        private static void FizzBuzz4()
        {
            Enumerable.Range(1, 100)
                .Select(v => new ValueName { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => { vn.Name += "Fizz"; return vn; })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => { vn.Name += "Buzz"; return vn; })
                .Replace(vn => String.IsNullOrEmpty(vn.Name), vn => { vn.Name = vn.Value.ToString(CultureInfo.InvariantCulture); return vn; })
                .Select(vn => vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }

        //FizzBuzz5:
        //Pass 1: 171
        //Pass 2: 92
        //Pass 3: 81
        //Pass 4: 81
        //Pass 5: 82
        //Pass 6: 84
        //Pass 7: 90
        //Pass 8: 85
        //Pass 9: 84
        //Pass 10: 85
        private static void FizzBuzz5()
        {
            Enumerable.Range(1, 100)
                .Select(v => new ValueName { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => { vn.Name = String.Join(String.Empty, vn.Name, "Fizz"); return vn; })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => { vn.Name = String.Join(String.Empty, vn.Name, "Buzz"); return vn; })
                .Replace(vn => String.IsNullOrEmpty(vn.Name), vn => { vn.Name = vn.Value.ToString(CultureInfo.InvariantCulture); return vn; })
                .Select(vn => vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }

        //FizzBuzz6:
        //Pass 1: 150
        //Pass 2: 85
        //Pass 3: 84
        //Pass 4: 84
        //Pass 5: 83
        //Pass 6: 84
        //Pass 7: 99
        //Pass 8: 89
        //Pass 9: 83
        //Pass 10: 82
        private static void FizzBuzz6()
        {
            Enumerable.Range(1, 100)
                .Select(v => new { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Fizz") })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Buzz") })
                .Select(vn => String.IsNullOrEmpty(vn.Name) ? vn.Value.ToString(CultureInfo.InvariantCulture) : vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }

        //FizzBuzzOop:
        //Pass 1: 141
        //Pass 2: 94
        //Pass 3: 83
        //Pass 4: 100
        //Pass 5: 100
        //Pass 6: 100
        //Pass 7: 100
        //Pass 8: 100
        //Pass 9: 100
        //Pass 10: 99
        private static void FizzBuzzOop()
        {
            Enumerable.Range(1, 100).ToList().ForEach(value => value.ToPrintable().Print());
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

        //FizzBuzzNormal:
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

    public static class NumericExtensions
    {
        public static bool IsDivisibleBy(this int value, int divisor)
        {
            return (value % divisor) == 0;
        }
    }

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
    }

    public delegate void ActionOut<T>(out T obj);

    public static class MethodExtensions
    {
        public static T ReturnOut<T>(this ActionOut<T> method)
        {
            T result;
            method(out result);
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
}