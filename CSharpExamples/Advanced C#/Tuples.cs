// Tuples are mutable value types

using System;
class Program
{
    public static void Main()
    {
        var bob = ("Bob", 23); // Tuple literal, compiler infers element types
        Console.WriteLine(bob.Item1);
        Console.WriteLine(bob.Item2);

        (string,int) Sam = ("Sam", 42); // Explicitly typed, can be returned from a method

        (string, int) person = GetPerson();
        Console.WriteLine("\n{0}", person);

        var tuple = (Name:"Kim", Age:56); // Elements can be named when creating tuple literals
        Console.WriteLine($"Name: {tuple.Name} Age: {tuple.Age}");

        var me = GetPersonNamedElements();
        Console.WriteLine($"Name: {me.Name} Age: {me.Age}");

        // ValueTuple.Create factory method:
        ValueTuple<string, int> vt1 = ValueTuple.Create("Vince", 28);
        (string, int) vt2 = ValueTuple.Create("Fred", 34);

        // Tuples support deconstruction pattern
        (string name, int age) = vt2;
        Console.WriteLine($"Name: {name} Age: {age}");
    }

    static (string, int) GetPerson()
    {
        Random rand = new Random();
        int r = rand.Next(3);
        (string, int) person;
        switch (r)
        {
            case 0:
                person = ("Jane", 37);
                break;
            case 1:
                person = ("James", 63);
                break;
            case 2:
                person = ("Sally", 18);
                break;
            default:
                person =("Default", -1);
                break;
        }
        return person;
    }

    // Elements can be named when specifiying tuple types
    static (string Name, int Age) GetPersonNamedElements() => ("Kyle", 32); 
}