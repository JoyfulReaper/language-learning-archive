using System;

public abstract class Animal // Abstract Class -- Can not be instantiated
{
    public string Name
        { private set; get; }
    public virtual bool Shedding // virtual function, can be overridden
        { set; get; } = false;

    public int Legs
        { private set; get; } = 4;

    public Animal(string name) => Name = name;
    public Animal() => Name = "Un-named";

    public abstract void Speak(); // abstract function, must be overridden
}

public class Cat : Animal // Inherits from Animal
{
    public Cat() : base() {}
    public Cat(string name) : base(name) {}
    public override bool Shedding // overides Animal's virtual method
    {
        get {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
                return true;
            else
                return false;
        }
    }
    public override void Speak() => Console.WriteLine("Meow?");
}

public class Dog : Animal // Inherits from Animal
{
    public Dog() : base() {}
    public Dog(string name) : base(name) {}

    public override void Speak() => Console.WriteLine("Woof!");
}

public class AbstractClasses
{
    public static void Main()
    {
        Cat meowser = new Cat();
        Dog shelly = new Dog("Shelly");

        Console.WriteLine($"meowser.Name: {meowser.Name}");
        meowser.Speak();
        Console.WriteLine($"shelly.Name: {shelly.Name}");
        shelly.Speak();
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


    }

    public static void DisplayAnimalName(Animal animal) // Polymorphism: Animal type can refer to its subclasses
    {
        System.Console.WriteLine($"The {nameof(animal)} is named {animal.Name}");
    }
}