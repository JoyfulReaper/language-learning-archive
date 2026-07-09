using System;

public class UnitConverter
{
	int ratio;	// Field
	public UnitConverter (int unitRatio) {ratio = unitRatio;} // Constructor
	public int Convert (int unit) { return unit * ratio; } // Method
}

class Test
{
	static void Main()
	{
		UnitConverter feetToInchesConverter = new UnitConverter (12);
		UnitConverter milesToFeetConverter = new UnitConverter (5280);
		
		Console.WriteLine(feetToInchesConverter.Convert(30));
		Console.WriteLine(feetToInchesConverter.Convert(100));
		Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));
	}
}