/*
* Kyle Givler 4/14 2020
* An exspansion of the FeetToInches example on page 16 of C# 7 in a Nutshell
*/

using System;

class Test
{
	static void Main()	
	{
        double input = 1;
        bool valid = true;

        while (true)
        {
            
            Console.Write("Enter number of feet to convert to inches: (<= 0 to quit): ");

            try {
                input = Double.Parse(Console.ReadLine());
                valid = true;
            } catch (FormatException e) {
                Console.WriteLine("Exception: " + e.Message); // Lets just dump the error message to the screen
                valid = false;
            }

            if(input <= 0)
                return;
            if (valid)
                Console.WriteLine(input + " feet is " + FeetToInches(input) + " inches ");
        }
	}

	static double FeetToInches(double feet)	
	{
		double inches = feet * 12;
		return inches;
	}
}