using System;
using Quantium.Hashable;

namespace Quantium.Hashable.Test
{
    public class Program
    {
        static int Main(string[] argv)
        {
            var myclass = new MyClass();
            Console.WriteLine(myclass);
            for(int a = 1; a < 5; ++a)
            {
                myclass.a = a;
                Console.WriteLine(myclass);
            }
            myclass.c = 3.141;
            Console.WriteLine(myclass);

            return 0;
        }
    }

    /// <summary>
    /// Sample class using the [Hashable] attribute to calculate the GetHashCode() method
    /// </summary>
    public class MyClass
    {
        [Hashable]
        public int a;
        [Hashable]
        private string b = "This is an internal string";
        internal double c = 1.133;

        /// <summary>
        /// Return a string representation of the object
        /// </summary>
        /// <returns>A string representation of the object</returns>
        public override string ToString()
        {
            int hash = GetHashCode();
            return $"a: {a}, b:{b}, c:{c}, Hash: {hash:X8}";
        }

        /// <summary>
        /// Calcualte a hash code based on the fields and properties indicated 
        /// by the [Hashable] attribute.
        /// </summary>
        /// <returns>A 32-bit integer hash value</returns>
        public override int GetHashCode()
        {
            return this.Hash();
        }
    }
}
