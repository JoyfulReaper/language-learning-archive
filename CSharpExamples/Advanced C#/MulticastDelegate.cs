// Multicast Delegate Example
public delegate void ProgressReporter (int percentComplete );

public class Util
{
    public static void HardWork(ProgressReporter p)
    {
        for(int i = 0; i <= 10; i++)
        {
            p(i * 10);
            System.Threading.Thread.Sleep(100);
        }
    }

    class Test
    {
        static void Main()
        {
            ProgressReporter p = ReportProgress;
            p += ReportRemaining; // Combine delegate instances

            Util.HardWork(p);
        }

        static void ReportProgress(int percentComplete) => System.Console.WriteLine($"Complete: {percentComplete}");
        static void ReportRemaining(int percentComplete) => System.Console.WriteLine($"Remaining: {100 - percentComplete}");
    }
}