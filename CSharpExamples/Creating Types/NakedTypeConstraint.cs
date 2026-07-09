// Naked Type Constraint Example
// where U:T
//
// Had some trouble understanding this one, also referenced:
// https://stackoverflow.com/questions/45967492/c-sharp-naked-type-constraints/45967536#45967536
//
// See C# 7 in a Nutshell pg 128 for other possible constraints
// C# 8 introduces more as well.

using System;
using System.Collections.Generic; 
using System.Linq; //OfType()

namespace NakedTypeConstraint
{
    class Animal {}
    class Dog : Animal {}

    class Stack<T>
    {
        int initialSize;
        public int Size { get => data.Count; }
        public bool Empty { get => data.Count == 0; }
        List<T> data;
        public Stack(int initialSize = 10) 
        { 
            this.initialSize = initialSize;
            data = new List<T>(initialSize);
        }
        public Stack(IEnumerable<T> data)
        {
            this.data = new List<T>(data);
        }
        public void Push (T obj)
        {
            data.Add(obj);
        }
        public T Pop()
        {
            if(Empty)
                throw new IndexOutOfRangeException("Stack is empty");
            
            T item = data[data.Count -1];
            data.RemoveAt(data.Count -1);
            return item;
        }
        public Stack<U> FilteredStack<U>() where U : T // Naked type constraint
        {                                       // The type argument supplied for U must be or derive from the argument supplied for T
            return new Stack<U>(data.OfType<U>());
        }
    }

    class Progam
    {
        public static void Main()
        {
            Stack<Animal> stack = new Stack<Animal>();
            ConsoleColor prev = Console.ForegroundColor;
 
            uint animal,dogs = 0;
            System.Console.Write("How many Animal? ");
            animal = UInt32.Parse(Console.ReadLine());
            System.Console.Write("How many dogs? ");
            dogs = UInt32.Parse(Console.ReadLine());

            for(int i = 0; i < animal; i++)
                stack.Push(new Animal());

            for(int i = 0; i < dogs; i++)
                stack.Push(new Dog());

            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine();
            System.Console.WriteLine("stack has {0} items", stack.Size);
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Filtering out Animals!");
            Console.ForegroundColor = ConsoleColor.Red;
            Stack<Dog> onlyDogs = stack.FilteredStack<Dog>();
            System.Console.WriteLine("onlyDogs has {0} items", onlyDogs.Size);
            
            Console.ForegroundColor = prev;
        }
    }
}