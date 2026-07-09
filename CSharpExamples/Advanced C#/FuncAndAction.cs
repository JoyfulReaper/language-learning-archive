using System;

class Util
{
    public static void Transform<T> (T[] values, Func<T,T> t)
    {
        for(int i = 0; i < values.Length; i++)
            values[i] = t(values[i]);
    }

    public static void DoSomething<T> (T message, Action<T> s)
    {
        s(message);
    }
}

class FuncAndAction
{
    public static void Main()
    {
        int[] values = { 1, 2, 3 };
        string[] stringVals = { "one", "two", "three" };

        Util.Transform(values, AddOne); // Hook in AddOne
        Util.Transform(stringVals, AddOne); // Hook in AddOne

        foreach(int i in values)
        {
            Console.WriteLine(i + " ");
        }

        Console.WriteLine();

        foreach(string s in stringVals)
        {
            Console.WriteLine(s + " ");
        }

        Console.WriteLine();

        Util.DoSomething("Hello, World!", PrintMessage);
    }

    static int Square(int x) => x * x;
    static int AddOne(int x) => x + 1;
    static string AddOne(string x) => x + "1";

    static void PrintMessage (string message) => Console.WriteLine(message);
}