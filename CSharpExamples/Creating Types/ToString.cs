// Overriding the ToString() Method
using System;
public class Dog
{
    public string Name;
    public override string ToString() => Name;

    public static void Main()
    {
        Dog d = new Dog {Name = "Woofers"};
        Console.WriteLine($"The dogs name is: {d}");
        Console.WriteLine($"The dogs name is: {d.ToString()}");
    }
}