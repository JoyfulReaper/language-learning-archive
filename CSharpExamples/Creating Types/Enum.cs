// Enum Example
using System;
using System.Collections.Generic;

namespace Enums
{
    public class Program
    {
        public enum Side {Left, Right, Top, Bottom}
        public enum Bside : byte {Left = 2, Right, Top = 10, Bottom} // Right == 2, Bottom == 11
        public static void Main()
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Side s1 = Side.Top;
            System.Console.WriteLine("Is s1 the top? {0}", s1 == Side.Top);
            System.Console.WriteLine("What is the value of Side.Right? {0}",(int)Side.Right);

            string[] names = Enum.GetNames(typeof(Side));
            System.Console.WriteLine("What are the names of the Sides? {0}", String.Join(", ", names));

            Array sides = Enum.GetValues(typeof(Bside));
            List<byte> sideValues = new List<byte>();
            foreach(Bside s in sides)
            sideValues.Add((byte)s);
            System.Console.WriteLine("What are the values of the Bsides? {0}", String.Join(",", sideValues));
            Console.ForegroundColor = prev;
        }
    }
}