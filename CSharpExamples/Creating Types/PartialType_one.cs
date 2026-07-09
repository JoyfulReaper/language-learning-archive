// Partial class example
using System;
partial class SomeClass
{
    int someField1 = 15;

    SomeClass()
    {
        Console.WriteLine("In constructor");
    }

    partial void IncreaseSomeField1(int num);
}