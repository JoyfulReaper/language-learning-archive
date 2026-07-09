// Delegate is an object that knows how to call a method
using System;
namespace Delegates
{
    delegate int Transformer (int x);

    class Progam
    {
        public static void Main()
        {
            Transformer t = null;

            while (true)
            {
                System.Console.WriteLine("1. Square\n2. Halve\n3. Double\n4. Quit");
                System.Console.Write("Option: ");
                int function = Int32.Parse(Console.ReadLine());
                
                switch (function)
                {
                    case 1:
                        t = Square;
                        break;
                    case 2:
                        t = Half;
                        break;
                    case 3:
                        t = Double;
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }

                System.Console.Write("Enter an Int32: ");
                int input = Int32.Parse(Console.ReadLine());
                int res = t(input);
                System.Console.WriteLine($"\nResult: {res}\n");
                
            }
        }

        static int Square(int x) => x * x;
        static int Half(int x) => x / 2;
        static int Double(int x) => x * 2; 
    }
}