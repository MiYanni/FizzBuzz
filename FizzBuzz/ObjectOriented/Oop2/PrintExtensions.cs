using System;

namespace FizzBuzz.ObjectOriented.Oop2
{
    internal static class PrintExtensions
    {
        public static void Print(this Element element)
        {
            Console.WriteLine(element.Representation);
        }
    }
}
