// Lambda expression is an unnamed metod written in place of a delegate instance
using System;
namespace LamdbaExample
{
    class Program
    {
        delegate int Transformer (int i); // Delegate type
        public static void Main()
        {
            Transformer sqr = x => x * x; // Lambda expression (parameters) => expression-or-statement-block
                                          // Each parameter corresponds to a delegate parameter, and type corresponds to return type of the delegate
            System.Console.WriteLine($"3 squared: {sqr(3)}\n");

            // Lambda expressions are commonly used with the Func and Action delegates:
            Func<int,int> sqr2 = x=> x * x;
            System.Console.WriteLine($"3 squared w/Func: {sqr2(3)}");

            // Example of an expression that excepts 2 parameters:
            Func<string,string,int> combinedStringLength = (s1, s2) => s1.Length + s2.Length;
            int totalLen = combinedStringLength("Hello", "World!");
            System.Console.WriteLine("\nLength of \"Hello\" + length of \"World!\": {0}", totalLen);

            // Closure, a lamba expression that captures a variable
            int factor = 2;
            Func<int, int> multipler = n => n * factor;
            Console.WriteLine($"\n2 multipled by {factor}: {multipler(3)}");
        }
    }
}