using System;

public class Animal
{
    public string Name
        { private set; get; }
    public bool Shedding
        { set; get; } = false;

    public int Legs
        { private set; get; } = 4;

    public Animal(string name) => Name = name;
    public Animal() => Name = "Un-named";
}

public class Cat : Animal // Inherits from Animal
{
    public Cat() : base() {}
    public Cat(string name) : base(name) {}
}

public class Dog : Animal
{
    public Dog() : base() {}
    public Dog(string name) : base(name) {}
}

public class Inheritance2
{
    public static void Main()
    {
        Cat meowser = new Cat();
        Dog shelly = new Dog("Shelly");

        Console.WriteLine($"meowser.Name: {meowser.Name}");
        Console.WriteLine($"shelly.Name: {shelly.Name}");
        Console.WriteLine($"meowser.Legs: {meowser.Legs}");
        Console.WriteLine($"shelly.Legs: {shelly.Legs}");
        shelly.Shedding = true;
        Console.WriteLine($"meowser.Shedding: {meowser.Shedding}");
        Console.WriteLine($"shelly.Shedding: {shelly.Shedding}");

        // Polymorphism
        Console.WriteLine();
        Cat cat = new Cat("Loopy");
        Dog dog = new Dog("Doopy");
        DisplayAnimalName(cat);
        DisplayAnimalName(dog);

        // Casting
        Dog furball = new Dog("Fur Ball");
        Animal dogAnimal = furball; // implicit upcast
        Console.WriteLine("\nDoes dogAnimal == furball? {0}", dogAnimal == furball); // Identical object, but a more restrictive view of it

        Cat sally = new Cat("Sally");
        Animal sallyAnimal = sally; // upcast
        Cat alsoSally = (Cat)sallyAnimal; // down cast
        Console.WriteLine("Does sally == alsoSally? {0}", sally == alsoSally);

        // The as Operator
        Animal strangeCreature = new Animal("Wild Lizzard");
        Dog pug = strangeCreature as Dog; // pug will be null, downcast fails
        Cat sallyAgain = sallyAnimal as Cat;
        if(pug == null)
        {
            Console.WriteLine("\nstrangeCreature is not a Dog");
        }
        if(sallyAnimal != null)
        {
            Console.WriteLine("sallyAnimal is a Cat");
        }
        if(sallyAnimal is Cat c) // is operator
            Console.WriteLine("sallyAnimal _is_ still a Cat.");
    }

    public static void DisplayAnimalName(Animal animal) // Polymorphism: Animal type can refer to its subclasses
    {
        System.Console.WriteLine($"The {nameof(animal)} is named {animal.Name}");
    }
}