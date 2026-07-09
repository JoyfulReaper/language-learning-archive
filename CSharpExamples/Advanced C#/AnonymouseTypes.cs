using System;
class Program
{
    public static void Main()
    {
        var Person = new { Name = "Sam", Age = 33 }; // Anonymous Type

        int age = 23;
        var Person2 = new { Name = "Sally", age, age.ToString().Length }; // Property name is inferred

        Console.WriteLine($"Name: {Person2.Name} Age: {Person2.age} Length: {Person2.Length}");

        var People = new[] // Array of anonymous types
        {
            new { Name = "Bob", Age = 12 },
            new { Name = "Bertha", Age = 82 },
        };

        dynamic Foo() => new {Name = "Bob", Age = 30}; // No static type saftey
        Console.WriteLine(Foo());
    }
}