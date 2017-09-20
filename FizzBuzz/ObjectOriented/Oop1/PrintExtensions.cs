using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Extensions;

namespace FizzBuzz.ObjectOriented.Oop1
{
    internal static class PrintExtensions
    {
        public static IPrintable ToPrintable(this int value)
        {
            // Note: This is like making a switch-statement/if-else into an object. Think about making an enumerable like that.
            var decider = new List<KeyValuePair<bool, IPrintable>>
            {
                // TODO: Simplify the syntax to allow {key, value} initialization.
                new KeyValuePair<bool, IPrintable>(value.IsDivisibleBy(3) && value.IsDivisibleBy(5), new FizzBuzz(value)),
                new KeyValuePair<bool, IPrintable>(value.IsDivisibleBy(3), new Fizz(value)),
                new KeyValuePair<bool, IPrintable>(value.IsDivisibleBy(5), new Buzz(value)),
                new KeyValuePair<bool, IPrintable>(true, new Element(value))
            };
            return decider.First(pair => pair.Key).Value;
        }
    }
}
