using System;

class JaggedArray
{
    public static void Main()
    {
        // Bracket for each dimension.
        int[][] matrix = new int[3][]; // 3 is the outermost dimension. Each inner array can be any length, and must be created manually

        for(int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[3]; // Create inner array
            for(int j = 0; j < matrix[i].Length; j++)
                matrix[i][j] = i * 3 + j;
        }

        // Jagged array can also be initilazed as follows:
        int [][] matrix2 = new int[][]
        {
            new int[] {0,1,2},
            new int[] {3,4,5},
            new int[] {6,7,8,9}
        };

        for(int i = 0; i < matrix2.Length; i++)
            for(int j = 0; j < matrix2[i].Length; j++)
                 Console.WriteLine("matrix2[{0}][{1}]: {2}", i, j, matrix2[i][j]);
    }
}