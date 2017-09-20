using System.Linq;
using FizzBuzz.ObjectOriented.Oop1;

namespace FizzBuzz.ObjectOriented
{
    internal static class Object1
    {
        // Pass 1: 141
        // Pass 2: 94
        // Pass 3: 83
        // Pass 4: 100
        // Pass 5: 100
        // Pass 6: 100
        // Pass 7: 100
        // Pass 8: 100
        // Pass 9: 100
        // Pass 10: 99
        public static void Solution()
        {
            Enumerable.Range(1, 100).ToList().ForEach(value => value.ToPrintable().Print());
        }
    }
}
