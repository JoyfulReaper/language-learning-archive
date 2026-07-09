// DateTime Example

using System;

namespace DateTimeTest
{
    class Program
    {
        public static void Main()
        {
            DateTimeOffset dto1 = new DateTimeOffset(2020, 5, 24, 11, 6, 34, new TimeSpan(-5, 0, 0));
            DateTimeOffset dto2 = new DateTimeOffset(2020, 5, 24, 11, 33, 45, DateTimeOffset.Now.Offset);

            Console.WriteLine (dto1);
            Console.WriteLine (dto2);

            Console.WriteLine();
            Console.WriteLine ($"Now: {DateTimeOffset.Now}");
            Console.WriteLine ($"UtcNow {DateTimeOffset.UtcNow}");

            DateTimeOffset dtNow = DateTimeOffset.Now;
            Console.WriteLine("\nDate");
            Console.WriteLine(dtNow.Year);
            Console.WriteLine(dtNow.Month);
            Console.WriteLine(dtNow.Day);
            Console.WriteLine(dtNow.DayOfWeek);
            Console.WriteLine(dtNow.DayOfYear);
            Console.WriteLine("\nTime");
            Console.WriteLine(dtNow.Hour);
            Console.WriteLine(dtNow.Minute);
            Console.WriteLine(dtNow.Second);
            Console.WriteLine(dtNow.Millisecond);
            Console.WriteLine(dtNow.Ticks);
            Console.WriteLine(dtNow.TimeOfDay);
            Console.WriteLine($"\nOffset: {dtNow.Offset}");
        }
    }
}