// DateTime Example

using System;

namespace DateTimeTest
{
    class Program
    {
        public static void Main()
        {
            DateTime dt1 = new DateTime(2020, 5, 24); // Time will be midnight
            DateTime dt2 = new DateTime(2020, 5, 24, 11, 0, 45, 14);

            // DateTimeKind enum: Unspcified, Local, UTC
            DateTime dt3 = new DateTime(2020, 5, 24, 11, 1, 15, 34, DateTimeKind.Local);

            Console.WriteLine (dt1);
            Console.WriteLine (dt2);
            Console.WriteLine (dt3);

            Console.WriteLine();
            Console.WriteLine ($"Today: {DateTime.Today}");
            Console.WriteLine ($"Now: {DateTime.Now}");
            Console.WriteLine ($"Tomrrow: {DateTime.Today.AddDays(1)}");
            Console.WriteLine($"Last Month: {DateTime.Today.AddMonths(-1)}");
        }
    }
}