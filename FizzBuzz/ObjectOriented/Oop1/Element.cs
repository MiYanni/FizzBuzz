using System;
using System.Globalization;

namespace FizzBuzz.ObjectOriented.Oop1
{
    internal class Element : IPrintable
    {
        public int Value { get; private set; }
        public string Representation { get; private set; }

        public Element(int value)
        : this(value, value.ToString(CultureInfo.InvariantCulture))
        {
        }

        protected Element(int value, string representation)
        {
            Value = value;
            Representation = representation;
        }

        public virtual void Print()
        {
            Console.WriteLine(Representation);
        }
    }
}
