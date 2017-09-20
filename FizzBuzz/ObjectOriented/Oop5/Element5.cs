using System;
using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzz.ObjectOriented.Oop5
{
    internal sealed class Element5
    {
        public int Value { get; }
        private readonly string _representation;

        private delegate string Representer<in T>(T obj);

        private struct Strings
        {
            public const string Fizz = "Fizz";
            public const string Buzz = "Buzz";
            public const string FizzBuzz = Fizz + Buzz;
        }

        private sealed class PredicateRepresenter
        {
            public Predicate<int> Predicate { get; }
            public Representer<int> Representer { get; }

            public PredicateRepresenter(Predicate<int> predicate, Representer<int> representer)
            {
                Predicate = predicate;
                Representer = representer;
            }
        }

        private static readonly List<PredicateRepresenter> Conversions = new List<PredicateRepresenter>
        {
            new PredicateRepresenter(v => IsDivisible(v, 15), v => Strings.FizzBuzz),
            new PredicateRepresenter(v => IsDivisible(v, 3), v => Strings.Fizz),
            new PredicateRepresenter(v => IsDivisible(v, 5), v => Strings.Buzz),
            new PredicateRepresenter(v => true, v => v.ToString(CultureInfo.InvariantCulture))
        };

        public Element5(int value)
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
            return Conversions.Find(p => p.Predicate(value)).Representer(value);
        }

        public override string ToString()
        {
            return _representation;
        }
    }
}