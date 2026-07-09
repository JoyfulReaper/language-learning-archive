// Example of a method ConvertMPHtoKPH method

using System;
 class SpeedConverter
 {
     public static void Main()
     {
         double input = 0;
         Console.Write("Enter speed in MPH to convert to KPH: ");
         try {
           input = Double.Parse(Console.ReadLine());
         } catch (FormatException e)
         {
             Console.WriteLine("You didn't enter a number :(");
             Console.WriteLine(e.ToString());
             System.Environment.Exit(0);
         }

        Console.WriteLine($"{input} MPH is {ConvertMPHtoKPH(input):0.00} KPH");

     }

/// <summary>
/// Convert Miles per hour to Kilometers per hour
/// </summary>
/// <param name="mph">The speed in miles per hour</param>
/// <returns>The speed in kilometers per hour</returns>
     private static double ConvertMPHtoKPH(double mph) // Simple method
     {
         return mph * 1.609344;
     }
 }