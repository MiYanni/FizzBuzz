using System;
using System.Globalization;
using System.Linq;
using FizzBuzz.Extensions;

namespace FizzBuzz.SingleStatement
{
    internal static class Single1
    {
        // Pass 1: 162
        // Pass 2: 80
        // Pass 3: 86
        // Pass 4: 97
        // Pass 5: 79
        // Pass 6: 83
        // Pass 7: 87
        // Pass 8: 84
        // Pass 9: 83
        // Pass 10: 82
        public static void Solution()
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
    }
}
