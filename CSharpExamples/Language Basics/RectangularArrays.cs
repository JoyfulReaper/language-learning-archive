using System;

class RectArray
{
    public static void Main()
    {
        int [,] matrix = new int[3,3];

        for(int i = 0; i < matrix.GetLength(0); i++) // Row
            for(int j = 0; j < matrix.GetLength(1); j++) // Column
                matrix[i,j] = i * 3 + j;

        int[,] matrix2 = new int[,]
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        for(int i = 0; i < matrix.GetLength(0); i++)
            for(int j = 0; j < matrix.GetLength(1); j++)
                Console.WriteLine("matrix[{0},{1}]: {2}", i, j, matrix[i,j]);

        for(int i = 0; i < matrix2.GetLongLength(0); i++)
        {
            Console.Write("\n");
            
            for(int j = 0; j < matrix2.GetLongLength(1); j++)
            {
                Console.Write(matrix2[i,j]);
            }
        }
    }
}