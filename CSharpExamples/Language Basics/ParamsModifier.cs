using System;

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
    }
}