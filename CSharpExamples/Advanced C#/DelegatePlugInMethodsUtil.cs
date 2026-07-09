using System;

public delegate int Transformer (int x);

class Util
{
    public static void Transform (int[] values, Transformer t)
    {
        for(int i = 0; i < values.Length; i++)
        {
            values[i] = t (values[i]);
        }
    }
}

class Test
{
    static void Main()
    {
        int[] values = {1, 2, 3};
        Util.Transform(values, Square);
        foreach (var item in values)
        {
            Console.Write(item + " ");
        }
    }

    static int Square (int x) => x * x;
}