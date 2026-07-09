// Finalizer Example, more covered later in the book...

using System;
class Finalizer
{
    Finalizer()
    {
        Console.WriteLine("In the constructor");
    }
    ~Finalizer()
    {
        Console.WriteLine("In the finalizer");
    }

    public static void Main()
    {
        Finalizer f = new Finalizer();
    }
}