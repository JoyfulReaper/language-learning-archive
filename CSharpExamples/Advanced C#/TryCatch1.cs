// Simple try/catch example
using System;
class Program
{
    static int Calc (int x) => 10 / x;

    static void Main()
    {
        try {
            Console.Write("Enter a number: ");
            int aNumber = Int32.Parse(Console.ReadLine());
            int res = Calc(aNumber);
            System.Console.WriteLine($"Result: {res}");
        } catch (DivideByZeroException e) {
            System.Console.WriteLine("X cannot be zero!");
        }
        Console.WriteLine("Exited Try/Catch blocks");
    }
}