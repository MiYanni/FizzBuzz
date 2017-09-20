using System;
using System.Globalization;

namespace FizzBuzz.Traditional
{
    internal static class Ternary1
    {
        // Pass 1: 131
        // Pass 2: 98
        // Pass 3: 99
        // Pass 4: 94
        // Pass 5: 95
        // Pass 6: 94
        // Pass 7: 99
        // Pass 8: 95
        // Pass 9: 95
        // Pass 10: 94
        public static void Solution()
        {
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            const string fizzBuzz = fizz + buzz;
            for (var value = 1; value <= 100; value++)
            {
                var isBy3 = value % 3 == 0;
                var isBy5 = value % 5 == 0;
                Console.WriteLine(
                    isBy3 && isBy5 ? fizzBuzz :
                        isBy3 ? fizz :
                            isBy5 ? buzz :
                                value.ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}
