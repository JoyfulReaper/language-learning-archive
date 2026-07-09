// Numeric types and datetimeoffset implement IFormattable
using System.Globalization;
using System;
class Program
{
    public static void Main()
    {
        NumberFormatInfo f = new NumberFormatInfo();
        f.CurrencySymbol = "$$";

        //format string is provides instructions C for currency symbol
        //format provider determines how the instructions are translated
        Console.WriteLine(3.ToString("C", f));
        Console.WriteLine();
        // null uses the default CultureInfo.CurrentCulture
        // Most types overload this so that null can be ommitted
        Console.WriteLine(10.3.ToString("C", null));
        Console.WriteLine(10.3.ToString("F3"));

        Console.WriteLine();
        // CultureInfo acts as indirection mechanism, returns NumberFormatInfo or DateTimeFormatInfo appliciable to the requested culture.
        CultureInfo uk = CultureInfo.GetCultureInfo("en-GB");
        Console.WriteLine(5.ToString("C", uk));

        Console.WriteLine();
        CultureInfo iv = CultureInfo.InvariantCulture;
        Console.WriteLine(5.ToString("C", iv));

        Console.WriteLine();
        f = new NumberFormatInfo();
        f.NumberGroupSeparator = ":";
        Console.WriteLine(123456.7890.ToString("N3", f));

        f = (NumberFormatInfo) CultureInfo.CurrentCulture.NumberFormat.Clone();
        Console.WriteLine(123456.7890.ToString("N3", f));
    }
}