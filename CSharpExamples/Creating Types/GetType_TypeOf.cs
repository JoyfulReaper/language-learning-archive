// Example from C#7 in a Nutshell
// GetType and typeof example

using System;
namespace GetType_TypeOf
{
    class Point { public int X, Y; }
    class Program
    {
        public static void Main()
        {
            Point p = new Point();
            Console.WriteLine(p.GetType().Name);
            Console.WriteLine(typeof (Point).Name);
            Console.WriteLine(p.GetType() == typeof(Point));
            Console.WriteLine(p.X.GetType().Name);
            Console.WriteLine(p.Y.GetType().FullName);
        }
    }
}