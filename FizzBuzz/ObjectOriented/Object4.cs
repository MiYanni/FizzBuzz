using System;
using System.Linq;
using FizzBuzz.Extensions;
using FizzBuzz.ObjectOriented.Oop4;

namespace FizzBuzz.ObjectOriented
{
    internal static class Object4
    {
        // Pass 1: 137
        // Pass 2: 80
        // Pass 3: 80
        // Pass 4: 77
        // Pass 5: 78
        // Pass 6: 80
        // Pass 7: 78
        // Pass 8: 81
        // Pass 9: 78
        // Pass 10: 76
        public static void Solution()
        {
            Enumerable.Range(1, 100).Select(value => new Element(value)).ForEach(Console.WriteLine);
        }
    }
}
