using System;

namespace ExplicitInterface
{
    // Two interfaces with conflicting member signatures
    interface I1 { void Foo(); }
    interface I2 { int Foo(); }
    public class Widget : I1, I2
    {
        public void Foo()
        {
            System.Console.WriteLine("Widget's implmentation of I1.Foo()");
        }
        int I2.Foo() // Explicit implementation
        {
            System.Console.WriteLine("Widget's implmentation of I2.Foo()");
            return (int)'I' + '2';
        }
    }

    public class Program
    {
        public static void Main()
        {
            Widget w = new Widget();
            w.Foo();
            ((I1)w).Foo();
            ((I2)w).Foo();

            System.Console.WriteLine();

            I2 i2 = new Widget();
            I1 i1 = new Widget();
            i2.Foo();
            i1.Foo();
            ((I2)i1).Foo();
        }
    }
}