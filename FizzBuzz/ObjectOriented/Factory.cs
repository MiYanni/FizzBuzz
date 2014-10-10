using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace FizzBuzz.ObjectOriented
{
    internal static class Factory
    {
        //public static IEnumerable<IPrintable> CreatePrintables(IEnumerable<int> values)
        //{
        //    // TODO: Make language able to autocast a lamba expression to a Func/Action.
        //    var isDivisible = new Func<int, int, bool>((value, divisor) => value % divisor == 0);
        //}

        public static IPrintable ToPrintable(this int value)
        {
            //// TODO: Make language able to autocast a lamba expression to a Func/Action.
            //var isDivisible = new Func<int, int, bool>((num, divisor) => num % divisor == 0);
            // Note: This is like makeing a switch-statement/if-else into an object. Think about making an enumerable like that.
            var decider = new List<KeyValuePair<bool, IPrintable>>
            {
                // TODO: Simplify the syntax to allow {key, value} initialization.
                new KeyValuePair<bool, IPrintable>(value.IsDivisible(3), new Fizz(value)),
                new KeyValuePair<bool, IPrintable>(value.IsDivisible(5), new Buzz(value)),
                new KeyValuePair<bool, IPrintable>(true, new Element(value))
            };
            return decider.First(pair => pair.Key).Value;
        }

        // TODO: Make language able to declare lambda extention methods.
        private static bool IsDivisible(this int value, int divisor)
        {
           return value % divisor == 0; 
        }
    }
}
