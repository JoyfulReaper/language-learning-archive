using System;
using System.Collections.Generic;

class Test
{
    static int Sum (params int[] ints)
    {
        int sum = 0;
        for(int i = 0; i < ints.Length; i++)
            sum += ints[i];

        return sum;
    }

    static void Main()
    {
        int total = Sum(1, 2, 3, 4); // Pass as many ints as needed, also able to pass an array:
        int arrayTotal = Sum( new int[] { 5, 6, 7, 8 });
        Console.WriteLine("Sum(1,2,3,4): {0}", total);
        Console.WriteLine("Sum (new int[] { 5, 6, 7, 8 }): " + arrayTotal);

        // This was a test for using an exception to break a loop
        List<int> numbers = new List<int>();
        Console.WriteLine();
        Console.WriteLine("Enter any input that causes Int32.Parse() to throw a FormatException to stop inputting");
        try {
            while (true)
            {
                Console.Write("Input a number: ");
                int number = Int32.Parse(Console.ReadLine());
                numbers.Add(number);
            }
        } catch (FormatException) {}

        Console.WriteLine("Sum of the number you entered: " + Sum(numbers.ToArray()));

        // This is a test for comma seperated input
        Console.Write("\nEnter numbers seperated by a comma: ");
        string numberString = Console.ReadLine();

        var split = numberString.Split(',');
        List<int> numberList = new List<int>();
        foreach (string s in split)
        {
            try{
                numberList.Add(Int32.Parse(s));
            } catch (FormatException) {
                Console.WriteLine("Invalid input: {0}", s);
            }
        }
        Console.WriteLine("Sum of the number you entered: " + Sum(numberList.ToArray()));

    }
}