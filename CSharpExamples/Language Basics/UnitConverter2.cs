// Some fun re-writing the unit converter example and adding error checking
// Kyle Givler
// 04/15/2020

using System;

public class UnitConverter
{
	int ratio;	// Field
	public UnitConverter (int unitRatio) {ratio = unitRatio;} // Constructor
	public double Convert (double unit) { return unit * ratio; } // Method
}

class Test
{
	static void Main()
	{
        double feet,miles = 0;
        const int INCHES_IN_FOOT = 12;
        const int FEET_IN_MILE = 5280;
        UnitConverter feetToInchesConverter, milesToFeetConverter;
        try
        {
            Console.Write("Creating feet to inches converter: How many feet: ");
            feet = double.Parse(Console.ReadLine());
            feetToInchesConverter = new UnitConverter (INCHES_IN_FOOT);

            Console.Write("Creating miles to feet converter: How many miles: ");
            miles = double.Parse(Console.ReadLine());
            milesToFeetConverter = new UnitConverter (FEET_IN_MILE);
        } catch (FormatException e) 
        {
            Console.WriteLine(e.Message);
            return;
        }

		
        string word;

        if (feet < 0)
        {
            Console.WriteLine("Negative feet? Nope!");
        } else {
            if (feet == 1)
                word = "foot";
            else
                word = "feet";
		    Console.WriteLine(feet + " " + word + " is " + feetToInchesConverter.Convert(feet) + " inches.");
        }

        if(miles < 0)
        {
            Console.WriteLine("Negative miles? Nope!");
        } else {
            if( miles == 1)
                word = "mile";
            else
                word = "miles";
		    Console.WriteLine(miles + " " + word + "  is " + milesToFeetConverter.Convert(miles) + " feet.");
        }
	}
}