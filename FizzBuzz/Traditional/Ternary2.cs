using System;
using FizzBuzz.Extensions;

namespace FizzBuzz.Traditional
{
    internal static class Ternary2
    {
        // Pass 1: 127
        // Pass 2: 95
        // Pass 3: 80
        // Pass 4: 79
        // Pass 5: 81
        // Pass 6: 82
        // Pass 7: 85
        // Pass 8: 89
        // Pass 9: 81
        // Pass 10: 79
        public static void Solution()
        {
            var createFizzBuzz = new Func<int, string>(value =>
                (value % 3 == 0 ? "Fizz" : String.Empty).JoinExt(String.Empty, value % 5 == 0 ? "Buzz" : String.Empty));
            for (var i = 1; i <= 100; Console.WriteLine(createFizzBuzz(i).IsNullOrEmpty() ? i.ToStringInvariant() : createFizzBuzz(i), ++i)) { }
        }
    }
}
