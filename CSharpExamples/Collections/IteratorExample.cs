using System;
using System.Collections;
using System.Collections.Generic;

public class MyCollection : IEnumerable
{
    int[] data = {1, 2, 3, 4};

    public IEnumerator GetEnumerator()
    {
        foreach(int i in data)
        {
            yield return i;
        }
    }
}

public class MyGenCollection : IEnumerable<int>
{
    int[] data = {1, 2, 3, 4};

    public IEnumerator<int> GetEnumerator()
    {
        foreach(int i in data)
        {
            yield return i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class Demo
{
    public static void Main()
    {
        MyCollection mc = new MyCollection();
        MyGenCollection mgc = new MyGenCollection();

        System.Console.WriteLine();
        foreach(var x in mc)
        {
            Console.WriteLine(x);
        }

        System.Console.WriteLine();
        foreach(var x in mgc)
        {
            System.Console.WriteLine(x);
        }
    }
}