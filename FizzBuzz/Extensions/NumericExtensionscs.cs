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
    }
}
