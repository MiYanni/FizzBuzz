using System.Globalization;

namespace FizzBuzz.ObjectOriented.Oop4
{
    internal sealed class Element4
    {
        public int Value { get; }
        private readonly string _representation;

        private struct Strings
        {
            public const string Fizz = "Fizz";
            public const string Buzz = "Buzz";
            public const string FizzBuzz = Fizz + Buzz;
        }

        private struct Indicies
        {
            public const int None = 0;
            public const int Fizz = 1;
            public const int Buzz = 2;
            public const int FizzBuzz = 3;
        }

        private delegate string Representer<in T>(T obj);

        private static readonly Representer<int>[] Representations =
        {
            v => v.ToString(CultureInfo.InvariantCulture),
            v => Strings.Fizz,
            v => Strings.Buzz,
            v => Strings.FizzBuzz
        };

        public Element4(int value)
        {
            _representation = DetermineRepresentation(value);
            Value = value;
        }

        private static bool IsDivisible(int value, int divisor)
        {
            return value % divisor == 0;
        }

        private static string DetermineRepresentation(int value)
        {
            var index = (IsDivisible(value, 3) ? Indicies.Fizz : Indicies.None) +
                        (IsDivisible(value, 5) ? Indicies.Buzz : Indicies.None);
            return Representations[index](value);
        }

        public override string ToString()
        {
            return _representation;
        }
    }
}