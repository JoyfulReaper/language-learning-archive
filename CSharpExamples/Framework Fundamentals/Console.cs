// Just some dumb Console Examples. C# 7 in a nutshell barely touches on the Console class here...

using System;
using System.Threading;

public class Program
{
    public static void Main()
    {
        //Console.WindowWidth = Console.LargestWindowWidth; // Uncomment for a wide window LOL!!! (Doesn't do anything in my VS code PS terminal though)
        ConsoleColor old = Console.ForegroundColor;
        Random rand = new Random();

        //Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Test...  ");
        for(int i = 0; i <= 100; i += 10)
        {
            Console.ForegroundColor = (ConsoleColor)rand.Next(0, 16);
            Console.CursorVisible = false;
            Console.Write("{0}%", i);
            Thread.Sleep(700);
            Console.CursorLeft -= 3;
        }
        Console.CursorVisible = true;
        Console.ForegroundColor = old;
    }
}