using System;
public class NamePrinter 
{
    public static void Main()
    {
        Console.Write("Please enter your name: ");
        var name = Console.ReadLine();
        PrintLine(name.Length);
        PrintName(name);
        PrintLine(name.Length);
    }
    private static void PrintLine(int len)
    {
        Console.Write("+");
        for(int i = 0; i < len; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("+");
    }

    private static void PrintName(string name)
    {
        Console.Write("|");
        Console.Write(name);
        Console.WriteLine("|");
    }
}