using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a word: ");
        var word = Console.ReadLine();

        // String implements IEnumerable, so we can call GetEnumerator()
        IEnumerator rator = word.GetEnumerator();

        while(rator.MoveNext())
        {
            char c = (char)rator.Current;
            Console.Write(c + ".");
        }

        Console.WriteLine("\n\nWith foreach:\n");

        foreach (char c in word)
        {
            Console.Write(c + ".");
        }
    }
}