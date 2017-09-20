using System;
using System.Globalization;
using System.Linq;
using FizzBuzz.Extensions;

namespace FizzBuzz.SingleStatement
{
    internal static class Single2
    {
        // Pass 1: 161
        // Pass 2: 83
        // Pass 3: 81
        // Pass 4: 80
        // Pass 5: 79
        // Pass 6: 82
        // Pass 7: 85
        // Pass 8: 78
        // Pass 9: 79
        // Pass 10: 82
        public static void Solution()
        {
            Enumerable.Range(1, 100)
                .Select(v => new { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Fizz") })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Buzz") })
                .Replace(vn => String.IsNullOrEmpty(vn.Name), vn => new { vn.Value, Name = vn.Value.ToString(CultureInfo.InvariantCulture) })
                .Select(vn => vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }
    }
}
