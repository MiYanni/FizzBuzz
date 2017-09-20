using System;
using System.Globalization;
using System.Linq;
using FizzBuzz.Extensions;

namespace FizzBuzz.SingleStatement
{
    internal static class Single4
    {
        // Pass 1: 175
        // Pass 2: 89
        // Pass 3: 83
        // Pass 4: 82
        // Pass 5: 84
        // Pass 6: 86
        // Pass 7: 86
        // Pass 8: 86
        // Pass 9: 88
        // Pass 10: 85
        public static void Solution()
        {
            Enumerable.Range(1, 100)
                .Select(v => new ValueName { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => { vn.Name += "Fizz"; return vn; })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => { vn.Name += "Buzz"; return vn; })
                .Replace(vn => String.IsNullOrEmpty(vn.Name), vn => { vn.Name = vn.Value.ToString(CultureInfo.InvariantCulture); return vn; })
                .Select(vn => vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }
    }
}
