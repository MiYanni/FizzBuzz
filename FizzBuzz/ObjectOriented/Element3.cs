using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz.ObjectOriented
{
    internal sealed class Element3
    {
        public int Value { get; private set; }

        private readonly string _representation;
        private static readonly List<Func<int,string>> Selections = new List<Func<int,string>> 
        {
            value => "FizzBuzz", 
            value => "Fizz", 
            value => "Buzz", 
            value => value.ToString(CultureInfo.InvariantCulture)
        };
        private static readonly List<Func<int,bool>> Selector = new List<Func<int,bool>> 
        {
            value => IsDivisible(value, 3) && IsDivisible(value, 5), 
            value => IsDivisible(value, 3), 
            value => IsDivisible(value, 5), 
            value => true
        };

        public Element3(int value)
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
            return Selections[Selector.FindIndex(predicate => predicate(value))](value);
        }

        public override string ToString()
        {
            return _representation;
        }
    }
}
