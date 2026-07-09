// Delegate Plug-in methods
using System;

namespace DelegatesPluginMethod
{
    delegate int Transformer(int x);
    class Program
    {
        public static void Transform(int[] values, Transformer t)
        {
            for(int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
        public static void Main()
        {
            Console.WriteLine("Enter space seperated list of Int32");
            Console.Write("Input: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] values = new int[input.Length];

            for(int i = 0; i < input.Length; i++)
                values[i] = Int32.Parse(input[i]);

            Transform(values, Square); // hook in Square method

            Console.WriteLine("\nOutput (Square): ");
            foreach(int i in values)
                Console.Write($"{i} ");


            Console.WriteLine("\n\nEnter space seperated list of Int32");
            Console.Write("Input: ");
            input = Console.ReadLine().Split(' ');
            values = new int[input.Length];

            for(int i = 0; i < input.Length; i++)
                values[i] = Int32.Parse(input[i]);

            Transform(values, Double); // hook in Double method

            Console.WriteLine("\nOutput (Double): ");
            foreach(int i in values)
                Console.Write($"{i} ");
        }

        static int Square(int x) => x * x;
        static int Double(int x) => x * 2;
    }
}