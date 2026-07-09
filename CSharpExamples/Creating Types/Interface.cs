using System.Collections;
using System;

namespace InterfaceNS
{
    internal class CountDown : IEnumerator
    {
        int count = 11;
        public bool MoveNext() => count-- > 0;
        public object Current => count;
        public void Reset() { throw new NotSupportedException(); }
    }

    public class Program
    {
        public static void Main()
        {
            IEnumerator e = new CountDown();
            while(e.MoveNext())
                System.Console.WriteLine(e.Current);
        }
    }
}