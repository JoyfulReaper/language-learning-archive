// Consists of only static Methods
using System;

static class StaticClass
{
    static int staticNumber = 0;

    static StaticClass() // static constuctor
    {
        Console.WriteLine("In Static Constructor, setting staticNumber = 1");
        staticNumber = 1;
    }

    static void IncrementNumber(int num)
    {
        staticNumber += num;
    }

    static void DecrementNumber(int num)
    {
        staticNumber -= num;
    }

    static void Main()
    {
        Console.WriteLine("staticNumber: {0}", StaticClass.staticNumber);
        Console.WriteLine("Adding 3");
        StaticClass.IncrementNumber(3);
        Console.WriteLine("staticNumber: {0}", StaticClass.staticNumber);
        Console.WriteLine("Substracking 54");
        StaticClass.DecrementNumber(54);
        Console.WriteLine("staticNumber: {0}", StaticClass.staticNumber);
    }
}