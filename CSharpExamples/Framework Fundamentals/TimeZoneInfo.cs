using System;
//using System.Globalization;

namespace TZInfoTest
{
    class Program
    {
        static void Main()
        {
            TimeZoneInfo zone = TimeZoneInfo.Local;
            System.Console.WriteLine("Your date and time {0}", DateTimeOffset.Now);
            System.Console.WriteLine("Your time zone: {0}", zone.StandardName);
            System.Console.WriteLine("Your time zone DST: {0}", zone.DaylightName);
            System.Console.WriteLine("DST is {0}.", zone.IsDaylightSavingTime(DateTimeOffset.Now) ? "in effect" : "not in effect");

            TimeZoneInfo westAU = TimeZoneInfo.FindSystemTimeZoneById("W. Australia Standard Time");
            Console.WriteLine();
            Console.WriteLine (westAU.Id);
            Console.WriteLine (westAU.DisplayName);
            System.Console.WriteLine("Base UTC Offset {0}", westAU.BaseUtcOffset);
            System.Console.WriteLine("Supports DST: {0}", westAU.SupportsDaylightSavingTime);
            System.Console.WriteLine("Date in Perth: {0}", TimeZoneInfo.ConvertTime(DateTimeOffset.Now, westAU));
        }
    }
}