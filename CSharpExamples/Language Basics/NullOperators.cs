using System;
using System.Text;

class Test
{
    public static void Main()
    {
        // Null Coalescing Operator
        string s1 = null;
        string s2 = s1 ?? "s1 is null!";
        Console.WriteLine(s2);

        s1 = "s1 is not null!";
        s2 = s1 ?? "s1 is null!";
        Console.WriteLine(s2);

        // Null Conditional Operator
        StringBuilder sb = null;
        string s3 = sb?.ToString(); // same as: string s3 = (sb == null ? null : sb.ToString());
        Console.WriteLine(s3 == null ? "s3 is null!" : "s3 is not null!");

        SomeClass sc = null;
        sc?.someMethod(); // Do nothing / NOOP
        sc = new SomeClass();
        sc.someMethod();

        // Combing the two
        sb = null;
        string s = sb?.ToString() ?? "sb is null!";
        Console.WriteLine(s);

        sb = new StringBuilder("sb is not null!");
        s = sb?.ToString() ?? "sb is null!";
        Console.WriteLine(s);
    }

    class SomeClass
    {
        public void someMethod () { Console.WriteLine ("someMethod"); }
    }
}