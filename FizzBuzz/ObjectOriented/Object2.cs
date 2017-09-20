using System.Linq;
using FizzBuzz.Extensions;
using FizzBuzz.ObjectOriented.Oop2;

namespace FizzBuzz.ObjectOriented
{
    internal static class Object2
    {
        // Pass 1: 129
        // Pass 2: 86
        // Pass 3: 81
        // Pass 4: 79
        // Pass 5: 80
        // Pass 6: 79
        // Pass 7: 82
        // Pass 8: 82
        // Pass 9: 80
        // Pass 10: 80
        public static void Solution()
        {
            Enumerable.Range(1, 100).Select(value => new Element2(value)).ForEach(Oop2Extensions.Print);
        }
    }
}
