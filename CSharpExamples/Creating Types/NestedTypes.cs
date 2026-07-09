// Nested Types Example
using System;
namespace NestedTypes
{
    public class TopLevel
    {
        private static int x; // Nested types have access to enclosing types members
        public class Nested { // Nested class
            public static void Foo() { System.Console.WriteLine("TopLevel.X: {0}", TopLevel.x); }
        }               
        public enum Color { Red, Blue, Tan } // Nested Enum
    }

    public class Program
    {
        public static void Main()
        {
            TopLevel.Color c = TopLevel.Color.Red; // Must be qualified
            TopLevel.Nested N = new TopLevel.Nested();

            System.Console.WriteLine("TopLevel.Color: {0}", Enum.GetName(typeof(TopLevel.Color),c));
            TopLevel.Nested.Foo();
        }
    }
}