using System;
using System.Collections.Generic;

class LocalMethods
{
    static void WriteCubes(params int[] inputs)
    {
        foreach(int i in inputs)
            Console.WriteLine("Cube of {0} is: {1}", i, Cube(i));

        // Local Method
        int Cube (int value) => value * value * value;
    }

    public static void Main()
    {
        List<int> intList = new List<int>();
        Console.Write("Enter a comma seperated list of intergers: ");
        string[] inputList = Console.ReadLine().Split(',');

        foreach (string s in inputList)
        {
            if(!Int32.TryParse(s, out int resInt))
            {
                Console.WriteLine($"{s.Trim()} is not a valid integer, skipping");
                continue;
            }
            intList.Add(resInt);
        }

        Console.WriteLine();
        WriteCubes(intList.ToArray());
    }
}