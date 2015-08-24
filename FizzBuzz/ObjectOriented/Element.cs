using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FizzBuzz.ObjectOriented
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
