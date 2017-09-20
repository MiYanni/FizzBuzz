using System;
using System.Linq;
using FizzBuzz.Extensions;
using FizzBuzz.ObjectOriented.Oop3;

namespace FizzBuzz.ObjectOriented
{
    internal static class Object3
    {
        // Pass 1: 134
        // Pass 2: 83
        // Pass 3: 85
        // Pass 4: 76
        // Pass 5: 79
        // Pass 6: 83
        // Pass 7: 78
        // Pass 8: 77
        // Pass 9: 82
        // Pass 10: 78
        public static void Solution()
        {
            Enumerable.Range(1, 100).Select(value => new Element3(value)).ForEach(Console.WriteLine);
        }
    }
}
