using System;
using System.Globalization;
using System.Linq;
using FizzBuzz.Extensions;

namespace FizzBuzz.SingleStatement
{
    internal static class Single6
    {
        // Pass 1: 150
        // Pass 2: 85
        // Pass 3: 84
        // Pass 4: 84
        // Pass 5: 83
        // Pass 6: 84
        // Pass 7: 99
        // Pass 8: 89
        // Pass 9: 83
        // Pass 10: 82
        public static void Solution()
        {
            Enumerable.Range(1, 100)
                .Select(v => new { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Fizz") })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Buzz") })
                .Select(vn => String.IsNullOrEmpty(vn.Name) ? vn.Value.ToString(CultureInfo.InvariantCulture) : vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }
    }
}
