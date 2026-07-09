// All objects can be upcast to object
using System;
namespace kgivlercom
{
    public class ObjectStack
    {
        int position;
        object[] data;
        public int Size { get => position; }
        public bool Empty => position == 0;
        public ObjectStack(uint initialSize = 10)
        {
            data = new object[initialSize];
        }
        public void Push (object obj)
        {
            if (position == data.Length)
                resize();
            data[position++] = obj;
        }
        public object Pop() => data[--position];
        public void resize()
        {
            uint newSize = (uint)(data.Length * .25 + data.Length);
            object[] newData = new object[newSize + 1];
            
            //System.Console.WriteLine($"RESIZE: New Length: {newSize + 1}");

            for(int i = 0; i < data.Length; i ++)
                newData[i] = data[i];
            data = newData;
        }
    }

    public class Program
    {
        public static void Main()
            {
                string input;
                ObjectStack os = new ObjectStack(1);

                do {
                    System.Console.WriteLine($"Length: {os.Size}");
                    System.Console.Write("Enter a string: ");
                    input = Console.ReadLine();
                    if(input != "")
                        os.Push(input);
                } while(input != "");

                Console.WriteLine("\nPopping the stack!");
                while(!os.Empty)
                {
                    Console.WriteLine(os.Pop());
                }
            }
    }
}