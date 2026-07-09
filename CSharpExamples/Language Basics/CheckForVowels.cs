// Use an arry for input validation example

using System;
public class CheckForVowels
{
    public static void Main()
    {
        char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'}; // Array Initialization
        bool hasVowel = false;

        Console.Write("Enter some text: ");
        var someText = Console.ReadLine();

        foreach (var vowel in vowels)
        {
            if (someText.Contains(vowel.ToString()))
            {
                hasVowel = true;
            }
        }
        Console.WriteLine("\nThe text you entered {0} a vowel", hasVowel ? "contains" : "does not contain");
    }
}