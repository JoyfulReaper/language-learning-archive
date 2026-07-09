// Static Constructors Execute once per type
// There can be only 1 static constructor and it can not take any paramaters. pg 93
// Better eample needed
using System;

class Test
{
    public static int a {get; set;}

    static Test() 
    {
        Console.WriteLine("In static constructor");
        a = 100;
    }
    public Test() => Console.WriteLine("In Constuctor");

    public static void Main()
    {
        Console.WriteLine("Creating a test object");
        Test t = new Test();
        Console.WriteLine(a);
    }
}