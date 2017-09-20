using System;

namespace FizzBuzz.ObjectOriented.Oop2
{
    internal static class Oop2Extensions
    {
        public static void Print(this Element2 element)
        {
            Console.WriteLine(element.Representation);
        }
    }
}
