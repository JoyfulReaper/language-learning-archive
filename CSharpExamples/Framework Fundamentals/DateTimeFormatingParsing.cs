using System;
using System.Threading;
class Progam
{
    public static void Main()
    {
        DateTimeOffset dtoNow = DateTimeOffset.Now;
        DateTime dtNow = DateTime.Now;

        Console.WriteLine(dtNow);
        Console.WriteLine(dtoNow);

        Console.WriteLine();
        Console.WriteLine(dtNow.ToShortDateString());
        Console.WriteLine(dtNow.ToLongDateString());

        Console.WriteLine();
        Console.WriteLine(dtNow.ToShortTimeString());
        Console.WriteLine(dtNow.ToLongTimeString());

        Thread.Sleep(3000);
        string dateString = DateTime.Now.ToString();
        DateTime fromString = DateTime.Parse(dateString);
        Console.WriteLine(fromString);
    }
}