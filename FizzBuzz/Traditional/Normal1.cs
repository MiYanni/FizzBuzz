using System;

namespace FizzBuzz.Traditional
{
    internal static class Normal1
    {
        // Pass 1: 160
        // Pass 2: 119
        // Pass 3: 121
        // Pass 4: 123
        // Pass 5: 122
        // Pass 6: 124
        // Pass 7: 126
        // Pass 8: 118
        // Pass 9: 127
        // Pass 10: 120
        public static void Solution()
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
    }
}
