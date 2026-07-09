using System;

public class LambdaExample
{
    public static void Main()
    {
        doSomething(x => Console.WriteLine(x), "This is a lambda");
    }

    public static void doSomething(Action<string> a, string s)
    {
        a(s);
    }
}