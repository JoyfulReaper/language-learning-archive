// Composite formatting combines variable substitution and format strings

using System;
using System.Globalization;
class Program
{
    public static void Main()
    {
        string composite = "Credit={0:C}";
        Console.WriteLine(string.Format(composite, 500));

        // Console class overloads WriteLine and Write to accept composite format strings
        Console.WriteLine(string.Format(composite, 800));

        //String.Format accepts optional format provider, can call ToString on arbitrary object and pass in format provider C# 7 NS pg 260)
        object someObject = "This is a string 1234";
        string s = string.Format (CultureInfo.InvariantCulture, "{0}", someObject);
        Console.WriteLine(s);
    }
}