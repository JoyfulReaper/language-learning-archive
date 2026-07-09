using System;

class SwitchOnTypes
{
    static void Main()
    {
        Console.WriteLine(TellMeTheType(2));
        Console.WriteLine(TellMeTheType("Apple"));
        Console.WriteLine(TellMeTheType(true));
    }

    static string TellMeTheType(object o) // Object can be any type
    {
        switch (o)
        {
            case int i:
                return ($"It's an int!\nThe square of {i} is {i * i}.");
            case string s:
                return ($"It's a string.\nThe length of {s} is {s.Length}");
            default:
                return "I don't know what that object is :'(";
        }
    }
}