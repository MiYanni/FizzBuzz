using System;
using System.Globalization;
using System.Linq;
using FizzBuzz.Extensions;

namespace FizzBuzz.SingleStatement
{
    internal static class Single5
    {
        // Pass 1: 171
        // Pass 2: 92
        // Pass 3: 81
        // Pass 4: 81
        // Pass 5: 82
        // Pass 6: 84
        // Pass 7: 90
        // Pass 8: 85
        // Pass 9: 84
        // Pass 10: 85
        public static void Solution()
        {
            Enumerable.Range(1, 100)
                .Select(v => new ValueName { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => { vn.Name = String.Join(String.Empty, vn.Name, "Fizz"); return vn; })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => { vn.Name = String.Join(String.Empty, vn.Name, "Buzz"); return vn; })
                .Replace(vn => String.IsNullOrEmpty(vn.Name), vn => { vn.Name = vn.Value.ToString(CultureInfo.InvariantCulture); return vn; })
                .Select(vn => vn.Name)
                .ToList().ForEach(Console.WriteLine);
        }
    }
}
