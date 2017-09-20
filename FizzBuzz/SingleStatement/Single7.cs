using FizzBuzz.Extensions;
using System;
using System.Linq;

namespace FizzBuzz.SingleStatement
{
    internal static class Single7
    {
        // Pass 1: 136
        // Pass 2: 80
        // Pass 3: 83
        // Pass 4: 84
        // Pass 5: 87
        // Pass 6: 88
        // Pass 7: 88
        // Pass 8: 90
        // Pass 9: 87
        // Pass 10: 89
        public static void Solution()
        {
            Enumerable.Range(1, 100)
                .Select(v => new { Value = v, Name = String.Empty })
                .Replace(vn => vn.Value.IsDivisibleBy(3), vn => new { vn.Value, Name = vn.Name.JoinExt(String.Empty, "Fizz") })
                .Replace(vn => vn.Value.IsDivisibleBy(5), vn => new { vn.Value, Name = vn.Name.JoinExt(String.Empty, "Buzz") })
                .Select(vn => vn.Name.IfNullOrEmptyThenDefault(vn.Value.ToStringInvariant()))
                .ForEach(Console.WriteLine);
        }
    }
}
