// Extension Methods allow an existing type to be extended with new methods
// without modifiying the original implementaion of the type.
//


using System;
using System.Text;

// Static method in a static class
public static class StringHelper
{
    public static bool IsCapitalized (this string s) // this modifer applied to fisrt parameter, the type to be extended
    {
        if(string.IsNullOrEmpty(s))
        {
            return false;
        }

        return char.IsUpper(s[0]);
    }

    public static bool EndsWithPeriod(this string s)
    {
        if(string.IsNullOrEmpty(s))
        {
            return false;
        }

        return s.EndsWith(".");
    }

    public static string Pluralize(this string s)
    {
        if(string.IsNullOrEmpty(s))
        {
            return "";
        }

        if(!s.EndsWith("s"))
        {
            s = s + "s";
        }

        return s;
    }

    public static string Capitalize(this string s)
    {
        if(string.IsNullOrEmpty(s))
        {
            return "";
        }

        StringBuilder sb = new StringBuilder(s);

        if(!Char.IsUpper(sb[0]))
        {
            sb[0] = char.ToUpper(sb[0]);
        }

        return sb.ToString();
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        // Can be called as if it was an instance method
        Console.WriteLine("Your sentence {0} start with a capital letter.", sentence.IsCapitalized() ? "does" : "does not");
        Console.WriteLine("Your sentence {0} end with a period.", sentence.EndsWithPeriod() ? "does" : "does not");
        Console.WriteLine();

        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        Console.WriteLine(word.Capitalize().Pluralize()); // Exstenion methon chaining
    }
}