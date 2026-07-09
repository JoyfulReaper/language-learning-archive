using System;
using System.Text;
class Test
{
    // Pass by value examples
    static void Foo (int p) // Pass by value
    {
        p = p + 1; // Increment p by one
        Console.WriteLine("Foo: {0}", p); // Write p to screen
    }

    static void Bar (StringBuilder BarSB) // Pass by Value
    {
        Console.WriteLine("In Bar()");
        BarSB.Append("test");
        BarSB = null; // Copy of the reference is assigned null
    }



    // Pass by reference examples
    static void FooRef (ref int p) // Pass by reference
    {
        p = p + 1; // Increment p by one
        Console.WriteLine("FooRef: {0}", p); // Write p to screen
    }

    static void BarRef (ref StringBuilder BarSB) // Pass by reference
    {
        Console.WriteLine("In BarRef()");
        BarSB.Append("test");
        BarSB = null;
    }

    static void Main()
    {
        // Pass by value Example
        Console.WriteLine("Passing x by value");
        int x = 8;
        Console.WriteLine("Main: {0}:", x);
        Foo(x); // Makes a copy of x
        Console.WriteLine("Main: {0}:", x);

        Console.WriteLine("Passing sb by value");
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("Main: {0}", sb.ToString());
        Bar(sb);
        Console.WriteLine("Main: {0}", sb.ToString());




        // Pass by reference Example
        Console.WriteLine("\nPassing x by reference");
        x = 8;
        Console.WriteLine("Main: {0}:", x);
        FooRef(ref x); // Pass a reference to x
        Console.WriteLine("Main: {0}:", x);

        Console.WriteLine("Passing sb by reference");
        sb = new StringBuilder();
        Console.WriteLine("Main: {0}", sb.ToString());
        BarRef(ref sb);
       try {
            Console.WriteLine("Main: {0}", sb.ToString());
         } catch (NullReferenceException) {
             Console.WriteLine("Caught NullReferenceException");
         }

    }
}

