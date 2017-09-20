using System;
using System.Linq;
using FizzBuzz.Extensions;
using FizzBuzz.ObjectOriented.Oop5;

namespace FizzBuzz.ObjectOriented
{
    internal static class Object5
    {
        // Pass 1: 136
        // Pass 2: 81
        // Pass 3: 78
        // Pass 4: 78
        // Pass 5: 81
        // Pass 6: 79
        // Pass 7: 78
        // Pass 8: 82
        // Pass 9: 79
        // Pass 10: 80
        public static void Solution()
        {
            Enumerable.Range(1, 100).Select(value => new Element(value)).ForEach(Console.WriteLine);
        }
    }
}
