// Generics Example using a stack
using System;
namespace GenericStack
{
    public class GenericStack<T> // Type paramater
    {
        int initialSize;
        int position;
        public int Size { get => position; }
        public bool Empty { get => Size == 0; }
        T[] data;
        public GenericStack(int initialSize = 10) 
        { 
            this.initialSize = initialSize;
            data = new T[initialSize];
        }
        public void Push (T obj)
        {
            if(position == data.Length)
                Resize();

            data[position++] = obj;
        }
        public T Pop()           => data[--position];
        private void Resize()
        {
            uint newSize = (uint)(data.Length * .25 + data.Length);
            T[] newData = new T[newSize + 1];

            for(int i = 0; i < data.Length; i ++)
                newData[i] = data[i];
            data = newData;
        }
    }

    class Program
    {
        public static void Main()
        {
            GenericStack<string> stack = new GenericStack<string>(); // Fill in the type parameter
            string input;
            do {
                System.Console.WriteLine($"Length: {stack.Size}");
                System.Console.Write("Enter a string: ");
                input = Console.ReadLine();
                if(input != "")
                    stack.Push(input);
            } while(input != "");

            Console.WriteLine("\nPopping the stack!");
            while(!stack.Empty)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}