using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz.ObjectOriented
{
    internal sealed class Element2
    {
        public int Value { get; private set; }
        public string Representation { get; private set; }

        public Element2(int value)
        : this(value, DetermineRepresentation(value))
        {
        }

        private static string DetermineRepresentation(int value)
        {
            var isDivisible = new Func<int, int, bool>((inputValue, divisor) => inputValue%divisor == 0);
            var by3 = isDivisible(value, 3);
            var by5 = isDivisible(value, 5);
            var selector = new List<bool> {by3 && by5, by3, by5, true};
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            var selections = new List<string> {String.Join(String.Empty, fizz, buzz), fizz, buzz, value.ToString(CultureInfo.InvariantCulture)};
            return selections[selector.FindIndex(condition => condition)];
        }

        private Element2(int value, string representation)
        {
            Value = value;
            Representation = representation;
        }

        public override string ToString()
        {
            return Representation;
        }
    }

    internal static class Element2Extensions
    {
        public static void Print(this Element2 element)
        {
            Console.WriteLine(element.Representation);
        }
    }
}
