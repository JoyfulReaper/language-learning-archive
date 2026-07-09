// Example of a nonpublic constructor. This class is a singleton.

using System;

class Test
{
    private static bool exists;
    private static Test instance;
    private string text;
    Test() // Private constructor
    {
        text = "The object has been created";
    }

    public static Test getTestObject()
    {
        if (!exists)
        {
            instance = new Test();
            exists = true;
        }
        
        return instance;
    }

    public string getText() => text;
}

class Program
{
    public static void Main()
    {
        Test t = Test.getTestObject();
        //Test q = new Test(); Will not compile, constructor is private
        Console.WriteLine(t.getText());
    }
}