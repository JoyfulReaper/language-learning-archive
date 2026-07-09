// Flag enum example
using System;
namespace Name
{
    class Program
    {
        [Flags] // Flags attribute
        public enum Sides { Nome = 0, Left = 1, Right = 2, Top = 4, Bottom = 8 } // Powers of 2
        public static void Main()
        {
            Sides leftRight = Sides.Left | Sides.Right;
            if( (leftRight & Sides.Left ) != 0)
                System.Console.WriteLine("Left is included");

            string formatted = leftRight.ToString();
            System.Console.WriteLine($"leftRight includes: {formatted}");

            System.Console.WriteLine();
            Sides s = Sides.Left;
            s |= Sides.Right;
            System.Console.WriteLine(s == leftRight);

            s ^= Sides.Right;
            System.Console.WriteLine(s);
        }
    }
}