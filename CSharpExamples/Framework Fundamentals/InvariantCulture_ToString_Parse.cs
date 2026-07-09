// Formatting an Parsing -> Using an inveriant culture to avoid mis-parsing.
// ToString and Parse respect the defualt culture by default.
// Specifiy CultureInfo.InvariantCulture to ovveride

using System;
using System.Globalization;
class Program
{
    public static void Main()
    {
        Console.WriteLine("de-DE Parsing \"1.234\": {0}", Double.Parse("1.234", new CultureInfo("de-DE")));
        Console.WriteLine("InvariantCulture parsing \"1.1234\": {0}", Double.Parse("1.234", CultureInfo.InvariantCulture));

        Console.WriteLine("\nde-DE ToString on \"1.234\": {0}", 1.234.ToString(new CultureInfo("de-DE")));
        Console.WriteLine("InvariantCulture ToString on \"1.1234\": {0}", 1.234.ToString(CultureInfo.InvariantCulture));
    }
}