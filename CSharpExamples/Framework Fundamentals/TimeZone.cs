using System;
using System.Globalization;
namespace TZTest
{
    class Program
    {
        public static void Main()
        {
            TimeZone zone = TimeZone.CurrentTimeZone;
            System.Console.WriteLine(zone.StandardName);
            System.Console.WriteLine(zone.DaylightName);

            DateTime dtNow = DateTime.Now;
            DateTime dt2 = new DateTime (2020, 12, 12);

            System.Console.WriteLine(zone.IsDaylightSavingTime(dtNow));
            System.Console.WriteLine(zone.IsDaylightSavingTime(dt2));
            System.Console.WriteLine(zone.GetUtcOffset(dtNow));
            System.Console.WriteLine(zone.GetUtcOffset(dt2));
            System.Console.WriteLine();

            DaylightTime day = zone.GetDaylightChanges(2020);
            System.Console.WriteLine("2020 DST Begin: {0}", day.Start.ToString());
            System.Console.WriteLine("2020 DST Ends: {0}", day.End.ToString());
            System.Console.WriteLine("Time delta: {0}", day.Delta);
        }
    }
}