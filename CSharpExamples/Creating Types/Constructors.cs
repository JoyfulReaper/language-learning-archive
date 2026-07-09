// Constructors run initiliaztion code on a class or a struct. 

using System;

class Panda
{
    string name;  // Field
    int age = 0;
    public Panda(string name) // Constructor (Same name as class, does not return a value)
    {
        this.name = name;
    }
    // Can also be written as:
    //public Panda(string name) => this.name = name;
    public Panda(string name, int age) // Constructors can be overloaded
    {
        this.name = name;
        this.age = age;

        if (age < 0)
            age = 0;
    }

    public static void Main()
    {
        Panda p = new Panda("Peter"); // Create a Panda instance and call the constructor
        Panda p2 = new Panda("Piper", 2);

        Console.WriteLine("See source code for Constructor examples");
    }
}