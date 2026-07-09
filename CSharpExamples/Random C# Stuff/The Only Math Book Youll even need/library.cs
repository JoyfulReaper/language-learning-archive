using System;

namespace OnlyMath
{
    public class OnlyMathLib
    {
        public static ConsoleColor DefaultColor {get; set;} = ConsoleColor.Yellow;

        public static decimal PercentChange(decimal amountOfChange, decimal baseAmount)
        {
            return (amountOfChange / baseAmount) * 1.0m; 
        }

        public static decimal RequireValidDecimal(string prompt)
        {
            bool valid = false;
            decimal result = 0;
            while(!valid)
            {
                Console.Write(prompt);
                valid = Decimal.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

        public static void ColorWrite(ConsoleColor color, string message)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = old;
        }

        public static void ColorWrite(string message)
        {
            ColorWrite(DefaultColor, message);
        }

        public static void ColorWriteLine(ConsoleColor color, string message)
        {
            ColorWrite(color, message + '\n');
        }

        public static void ColorWriteLine(string message)
        {
            ColorWriteLine(DefaultColor, message);
        }
    }
}