using System.Diagnostics;
using System.Globalization;
using System.Linq;
using FizzBuzz.Extensions;

namespace FizzBuzz.Traditional
{
    internal static class Functional1
    {
        // NOT TIMED YET.
        public static void Solution()
        {
            Enumerable.Range(1, 100).Select(i => {
                if (i % 3 == 0 && i % 5 == 0)
                    return "FizzBuzz";
                if (i % 3 == 0)
                    return "Fizz";
                if (i % 5 == 0)
                    return "Buzz";
                return i.ToString(CultureInfo.InvariantCulture);
            }).ForEach(i => Debug.WriteLine(i));
        }
    }
}
