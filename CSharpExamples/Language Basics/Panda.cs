using System;
public class Panda
{
    public string name; // Instance field
    public static int Population; // Static field

    public Panda (string n) // Constructor
    {
        name = n; // Assign the instance field
        Population = Population + 1; // Increment the static Population field
    }
}

class Test
{
	static void Main()
	{
		Panda p1 = new Panda ("Pan Dee");
        Panda p2 = new Panda ("Pan Dah");

        Console.WriteLine(p1.name);
        Console.WriteLine(p2.name);

        Console.WriteLine ("There are " + Panda.Population + " pandas!");
	}
}