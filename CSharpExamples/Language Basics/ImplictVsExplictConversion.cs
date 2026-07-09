using System;
class Test
{
    public static void Main()
    {
        int x = 12345; // int is a 32 but integer
        long y = x; // Implicit conversion to 64-bit integer
        short z = (short) x; // Explicit converison to 16 bit integer

        Console.WriteLine("Complete, see source code");
    }
}