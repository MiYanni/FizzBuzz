using System;
using System.Globalization;
using System.Linq;

namespace FizzBuzz.Traditional
{
    internal static class Internet1
    {
        // Pass 1: 138
        // Pass 2: 83
        // Pass 3: 79
        // Pass 4: 94
        // Pass 5: 81
        // Pass 6: 82
        // Pass 7: 88
        // Pass 8: 83
        // Pass 9: 86
        // Pass 10: 80
        // http://derreckdean.wordpress.com/2011/05/09/fizzbuzz-in-one-line-c-linq/
        public static void Solution()
        {
            Enumerable.Range(1, 100).ToList().ForEach(i => Console.WriteLine(
                i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" :
                    i % 5 == 0 ? "Buzz" :
                        i % 3 == 0 ? "Fizz" :
                            i.ToString(CultureInfo.InvariantCulture)));
        }
    }
}
