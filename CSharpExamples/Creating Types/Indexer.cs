// Implmenting an indexer on an int stack
// Sorry stack was the first thing that came to mind didn't want to do the book's example

using System;
using System.Collections.Generic;

class StackWithIndexer
{
    public int Count {get; private set;}
    private List<int> backing = new List<int>();
    public void push(int value) => backing.Insert(Count++, value);
    public int pop() 
    {
        int val = backing[Count - 1];
        backing.RemoveAt(--Count);
        return val;
    }

    public int this [int index] // indexer implementation
    {
        get 
        {
            if (index > Count || index < 0)
                throw new IndexOutOfRangeException("Invaild index");

            return backing[index];
        }
        set
        {
            if (index > Count || index < 0)
                throw new IndexOutOfRangeException("Invaild index");

            backing[index] = value;
        }
    }

    public static void Main()
    {
        StackWithIndexer Stack = new StackWithIndexer();

        string input;
        int pushNumber = 0;
        for(int i = 0; i < 5; i++)
        {
            Console.Write("Give me a number to push: ");
            do
            {
                input = Console.ReadLine();
            } while(!Int32.TryParse(input, out pushNumber));
            Stack.push(pushNumber);
        }

        for(int i = 0; i < Stack.Count; i++) // Output the value of each index in the stack
            Console.WriteLine("Stack[{0}]: {1}", i, Stack[i]);

        while (Stack.Count > 0)
            Console.WriteLine("Pop: {0}", Stack.pop());
    }

}