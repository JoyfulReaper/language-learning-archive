using System;
public class BaseClass
{
    public int x;
    public BaseClass() { Console.WriteLine("In BaseClass()"); }
    public BaseClass(int x) 
    {
        Console.WriteLine("In BaseClass(int x)");
        this.x = x;
    }
    public virtual void PrintSomething()
    {
        Console.WriteLine("In BaseClass.PrintSomething()");
    }
}

public class SubClass : BaseClass
{
    public SubClass() : base() {}
    public SubClass(int x) : base(x)
    {
        Console.WriteLine("In SubClass(int x)");
    }
    public override void PrintSomething()
    {
        base.PrintSomething();
        Console.WriteLine("In SubClass.PrintSomething()");
    }
}

public class BaseKeyword
{
    public static void Main()
    {
        Console.WriteLine("Creating s");
        SubClass s = new SubClass();
        s.PrintSomething();

        Console.WriteLine("\nCreating s1");
        SubClass s1 = new SubClass(123);
        s1.PrintSomething();
    }
}