using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        foreach (int fib in EvenNumbersOnly(Fibs(6)))
        {
            System.Console.Write(fib + " ");
        }
    }

    static IEnumerable<int> Fibs(int fibCount)
    {
        for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
        {
            // yeild return returns the next element requested from this enumerator
            // Control is returned to caller, but the state is maintained
            yield return prevFib;
            int newFib = prevFib + curFib;
            prevFib = curFib;
            curFib = newFib;
        }
    }

    static IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
    {
        foreach (int x in sequence)
            if((x%2) == 0)
                yield return x;
    }
}