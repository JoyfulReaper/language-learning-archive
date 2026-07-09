// TimeSpan struct can represent an interval of time or a time of day / time since midnight

using System;

class Program
{
    public static void Main()
    {
        TimeSpan t = new TimeSpan(14, 30, 15); // Time of day
        Console.WriteLine($"Time: {t.Hours}:{t.Minutes}:{t.Seconds}");
        Console.WriteLine(t);

        Console.WriteLine();
        t = TimeSpan.FromDays(3); // Static from methods for specifiying and interval from a single unit (Days)
        Console.WriteLine(t);
        Console.WriteLine();

        Console.Write("Days: ");
        int days = Int32.Parse(Console.ReadLine());
        Console.Write("Hours: ");
        int hours = Int32.Parse(Console.ReadLine());
        Console.Write("Minutes: ");
        int minutes = Int32.Parse(Console.ReadLine());
        Console.Write("Seconds: ");
        int seconds = Int32.Parse(Console.ReadLine());

        Console.WriteLine();
        TimeSpan ts1 = new TimeSpan(days,hours,minutes,seconds);
        Console.WriteLine(ts1);
        Console.WriteLine("Adding 121 seconds and 1001 ms");
        ts1 += TimeSpan.FromSeconds(121) + TimeSpan.FromMilliseconds(1001);

        Console.WriteLine(ts1);
        Console.WriteLine("\nTotal Days {0}", ts1.TotalDays);
        Console.WriteLine("Total Hours {0}", ts1.TotalHours);
        Console.WriteLine("Total Minutes {0}", ts1.TotalMinutes);
        Console.WriteLine("Total Seconds {0}", ts1.TotalSeconds);
        Console.WriteLine("Total Miliseconds {0}", ts1.TotalMilliseconds);
    }
}