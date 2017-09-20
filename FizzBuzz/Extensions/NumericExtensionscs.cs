using System.Globalization;

namespace FizzBuzz.Extensions
{
    internal static class NumericExtensions
    {
        public static bool IsDivisibleBy(this int value, int divisor)
        {
            return value % divisor == 0;
        }

        public static string ToStringInvariant(this int value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        //public static IPrintable ToPrintable(this int value)
        //{
        //    // Note: This is like making a switch-statement/if-else into an object. Think about making an enumerable like that.
        //    var decider = new List<KeyValuePair<bool, IPrintable>>
        //    {
        //        // TODO: Simplify the syntax to allow {key, value} initialization.
        //        new KeyValuePair<bool, IPrintable>(value.IsDivisibleBy(3) && value.IsDivisibleBy(5), new ObjectOriented.Oop1.FizzBuzz(value)),
        //        new KeyValuePair<bool, IPrintable>(value.IsDivisibleBy(3), new Fizz(value)),
        //        new KeyValuePair<bool, IPrintable>(value.IsDivisibleBy(5), new Buzz(value)),
        //        new KeyValuePair<bool, IPrintable>(true, new Element(value))
        //    };
        //    return decider.First(pair => pair.Key).Value;
        //}
    }
}
