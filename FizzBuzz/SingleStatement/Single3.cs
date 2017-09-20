using System;
using System.Globalization;
using System.Linq;
using FizzBuzz.Extensions;

namespace FizzBuzz.SingleStatement
{
    internal static class Single3
    {
        // Pass 1: 152
        // Pass 2: 86
        // Pass 3: 81
        // Pass 4: 82
        // Pass 5: 99
        // Pass 6: 85
        // Pass 7: 87
        // Pass 8: 81
        // Pass 9: 91
        // Pass 10: 91
        public static void Solution()
        {
            new int[100]
                .Select((v, i) => new { Value = i + 1, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Fizz") })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => new { vn.Value, Name = String.Join(String.Empty, vn.Name, "Buzz") })
                .Replace(vn => String.IsNullOrEmpty(vn.Name), vn => new { vn.Value, Name = vn.Value.ToString(CultureInfo.InvariantCulture) })
                .Select(vn => vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }
    }
}
