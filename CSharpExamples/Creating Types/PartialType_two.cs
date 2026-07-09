// Partial class example
using System;
partial class SomeClass
{
    int someField2 = 25;

    partial void IncreaseSomeField1(int num)
    {
        someField1 += num;
    }

    public static void Main()
    {
        SomeClass sc = new SomeClass();
        Console.WriteLine($"someField2: {sc.someField2}");
        Console.WriteLine($"someField1: {sc.someField1}");
        Console.WriteLine("Increasing someField1 by 76");
        sc.IncreaseSomeField1(76);
        Console.WriteLine($"someField1: {sc.someField1}");
    }
}