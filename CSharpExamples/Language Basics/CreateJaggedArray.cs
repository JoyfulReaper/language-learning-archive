// Jagged Array Example

using System;
public class CreateJaggedArray
{
    public static void Main()
    {
        Console.Write("Number of arrays outer arrays: ");
        var outerNum = Int32.Parse(Console.ReadLine()); // No error checking
        int[][] jaggedArray = new int[outerNum][];

        for(int i = 0; i < outerNum; i++)
        {
            Console.Write($"Number of elements in outer array {i}: ");
            jaggedArray[i] = new int[Int32.Parse(Console.ReadLine())]; // No error checking
        }

        for(int i = 0; i < jaggedArray.Length; i++)
        {
            for(int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Enter value for array[{i}][{j}]: ");
                jaggedArray[i][j] = Int32.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\n\nResult: ");
        for(int i = 0; i < jaggedArray.Length; i++)
        {
            for(int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}