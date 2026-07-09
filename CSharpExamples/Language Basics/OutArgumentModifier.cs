using System;
class test
{
    static void Split (string name, out string firstNames, out string LastName)
    {
        int lastSpaceIndex = name.LastIndexOf(' ');
        firstNames = name.Substring(0, lastSpaceIndex);
        LastName = name.Substring(lastSpaceIndex + 1);
    }

    static void Main()
    {
        string a,b;
        Split("Steve Anita Smith", out a, out b); // Out paramaters are passed by reference
        Console.WriteLine("First Name(s): {0}", a);
        Console.WriteLine("Last Name: {0}", b);

        Split("Stan Something Smith", out string NewA, out _); // Since c# 7 declare variables (NewA on the fly). Ignore an output argument with _
        Console.WriteLine("First Name(s): {0}", NewA);           
    }
}