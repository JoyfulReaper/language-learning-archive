using System;
class Octopus // A class is a reference type
{
    // Fields: variables that are members of a class or a struct
    string name; // Name field
    public int age = 10; // Optional field initialization
    static readonly int legs = 8, eyes = 2; // declare two static readonly fields at the same time. Readonly fields can not be changed after they are initialized
    public int HungerPercent {get; private set;} = 0; // Simple property

    // Instance methods
    public bool isHungry()
    {
        return HungerPercent > 60;
    }
    // Method consisting of a single expression can be expressed as an expression-bodied method
    public void Eat(int amount) => HungerPercent -= amount; 
    // Overloaded method (two methods with the same name)
    public void Eat(string amount) => HungerPercent -= Int32.Parse(amount);

    public void Digest(int amount) => HungerPercent += amount;

    public static void Main()
    {
        Octopus o = new Octopus();
        o.name = "Fred";
        
        Console.WriteLine("The octopus {0} hungry!\n", o.isHungry() ? "is" : "isn't");

        Console.WriteLine("Digesting 75 food!");
        o.Digest(75);
        Console.WriteLine("The octopus is {0}% hungry\n", o.HungerPercent);

        Console.WriteLine("Feeding the octopus with an int...");
        o.Eat(10);
        Console.WriteLine("The octopus is {0}% hungry\n", o.HungerPercent);

        Console.WriteLine("Feeding the octopus with a string...");
        o.Eat("10");
        Console.WriteLine("The octopus is {0}% hungry\n", o.HungerPercent);

        Console.WriteLine("The octopus is named: {0}", o.name);
        Console.WriteLine("The octopus is age: {0}", o.age);
        Console.WriteLine("The octopus has {0} legs and {1} eyes!", Octopus.legs, Octopus.eyes);
    }
}

