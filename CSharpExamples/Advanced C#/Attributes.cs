// This example barely scratches the surface, and the book presents this as an intro with more later

using System;
using System.Runtime.CompilerServices;

[ObsoleteAttribute] // All attributes end with Attribute so [Obsolete] also works
class Obs{
    public int numer = 5;
}

class Program
{
    public static void Main()
    {
        Obs o = new Obs(); // Compiler warning due to [Obsolete] attribute
        o.numer = 42;

        Foo();
    }

    //Caller info attributes
    // Optional parameters
    static void Foo (
    [CallerMemberName] string memberName = null,
    [CallerFilePath] string filePath = null,
    [CallerLineNumber] int lineNumber = 0 )
    {
        Console.WriteLine("Foo");
        Console.WriteLine(memberName);
        Console.WriteLine(filePath);
        Console.WriteLine(lineNumber);
    }
}