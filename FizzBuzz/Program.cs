using System;
using System.Diagnostics;
using System.Linq;
using FizzBuzz.Extensions;

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
                return $"Pass {v}: {stopwatch.ElapsedMilliseconds}";
            }).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }

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
    }
}