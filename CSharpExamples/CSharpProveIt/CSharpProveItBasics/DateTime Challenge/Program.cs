namespace DateTime_Challenge;

internal class Program
{
    static void Main(string[] args)
    {
        var format = GetDateFormat();
        Console.WriteLine();

        Console.WriteLine("Please enter a date: ");
        var dateString = Console.ReadLine();
        var date = ProcessDate(dateString, format);

        var daysAgo = DateTime.Now - date;

        if(daysAgo.Ticks < 0)
        {
            Console.WriteLine("Days from now: " + Math.Round(-daysAgo.TotalDays, 0, MidpointRounding.AwayFromZero));
        }
        else
        {
            Console.WriteLine("Days ago: " + Math.Round(daysAgo.TotalDays, 0, MidpointRounding.AwayFromZero));
        }

        Console.WriteLine();
        Console.WriteLine("Enter time: ");
        var timeString = Console.ReadLine();
        var timeAgo = ProcessTime(timeString);

        if(timeAgo.Ticks < 0)
        {
            timeAgo = timeAgo.Add(TimeSpan.FromHours(24));
        }
        
        Console.WriteLine("Hours ago: " + timeAgo.Hours);
        Console.WriteLine("Minutes ago: " + timeAgo.Minutes);
    }

    private static TimeSpan ProcessTime(string timeString)
    {
        DateTime prevTime = DateTime.ParseExact(timeString, "h:mm tt", null);
        var difference = DateTime.Now - prevTime;
        return difference;
    }

    private static DateTime ProcessDate(string dateString, DateType format)
    {
        DateTime outDate = DateTime.Now;
        if (format == DateType.MonthFirst)
        {
            outDate = DateTime.ParseExact(dateString, "M/d/yy", null);
        }
        else
        {
            outDate = DateTime.ParseExact(dateString, "d/M/yy", null);
        }

        return outDate;
    }

    private static DateType GetDateFormat()
    {
        Console.WriteLine("What dateformat do you prefer?");
        Console.WriteLine("1) mm/dd/yy");
        Console.WriteLine("2) dd/mm/yy");

        DateType output = DateType.DayFirst;
        var response = Console.ReadLine();
        int responseInt;
        if (!int.TryParse(response, out responseInt) || responseInt > 2 || responseInt < 1)
        {
            Console.WriteLine("Please make a valid choice!\n");
            return GetDateFormat();
        }

        switch (responseInt)
        {
            case 1:
                output = DateType.MonthFirst;
                break;
            case 2:
                output = DateType.DayFirst;
                break;
        }

        return output;
    }
}
