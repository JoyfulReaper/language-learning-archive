using System;

class Test
{
    public static void Main()
    {
        // If statement. true is 5 < 6, false if 5 > 6
        if (5 < 6)
            Console.WriteLine("5 is less than 6 after all!");

        // Do while loop
        string number;
        int resNumber;
        do {
            Console.Write("Enter a number: "); 
            number = Console.ReadLine(); // read string (hopefully a number) from command line
        } while (!Int32.TryParse(number, out resNumber)); // loop until a number is entered

        if (resNumber < 100) // Check if the number entered was < 100
            Console.WriteLine("You entered a number less than 100");
        else // Display a diffrent message if the number is >=
            Console.WriteLine("You entered a number equal to or greater than 100");
    }
}