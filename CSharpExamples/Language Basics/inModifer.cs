// in keyword passes an argument by reference but does not allow it to be modified
using System;
public class inModifier
{
    public static void Main()
    {
        string barString = "This is the in string";
        Foo(barString);
    }

    private static void Foo(in string bar)
    {
        //bar = "Set it to something else!"; parameter passed by reference but can not be modified
        Console.WriteLine($"Bar is: {bar}");
    }
}