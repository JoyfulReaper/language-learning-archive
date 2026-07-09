using System;
class SwitchWhen
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        bool result = Int32.TryParse(Console.ReadLine(), out int number);
        
        switch ((object)result)
        {
            case bool b when b == true:
                Console.WriteLine("You entered the number: {0}", number);
                break;
            case bool b:
                Console.WriteLine("You didn't enter a number!");
                break;
           default:
                Console.WriteLine("result wasn't a bool for some reason!");
                break;
        }
    }
}