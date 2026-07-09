using System;
using System.Globalization;
class Program
{
    public static void Main()
    {
        int minusTwo = int.Parse("(2)", NumberStyles.Integer | NumberStyles.AllowParentheses);
        Console.WriteLine(minusTwo);
        decimal fivePointTwo = decimal.Parse("$5.20", NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
        Console.WriteLine(fivePointTwo);
    }
}