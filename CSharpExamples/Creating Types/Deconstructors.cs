// Deconstructor Example

using System;

class Dog
{
    public enum Gender { Male, Female };
    public int Age;
    public readonly Gender DogGender;
    public string Name;

    public Dog(string name, int age, Gender gen)
    {
        Name = name;

        if(age < 0 || age >= 25)
            throw new ArgumentException("age must be between 0 and 25 inclusive");
        Age = age;

        DogGender = gen;
    }

    // Deconstructor.
    public void Deconstruct(out string name, out int age, out Gender gender)
    {
        name = Name;
        age = Age;
        gender = DogGender;
    }

    public static void Main()
    {
        Dog Buddy = new Dog("Buddy", 4, Gender.Male);
        Dog Shelly = new Dog("Shelly", 5, Gender.Female);

        (string name, int age, Gender gender) = Buddy; // Syntax to call Deconstructor
        Console.WriteLine("Deconstructed Buddy: {0} {1} {2}", name, age, gender);

        var (sName, sAge, sGender) = Shelly;
        Console.WriteLine("Deconstructed Shelly: {0} {1} {2}", sName, sAge, sGender);
    }
}