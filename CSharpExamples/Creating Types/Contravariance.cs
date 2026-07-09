// Contravariance example
/*
* Extends the covariance example
* Assuming A is convertable to B, X has contravariance type parameters if X<B> is convertabale to X<A>
* Mark type paramters with in keyword
* Type parameters on Interfaces and Delegates can be declared covariant
*/
using System;
using System.Collections.Generic;
namespace Covariance
{
    public interface IPoppable<out T> { T Pop(); } // Declared covariant with out keyword. T will only be used in out positions.
    public interface IPushable<in T> { void Push (T obj); } // Declared contraveriant with in keyword. T will only be used in in positions.
    public class Animal {}
    public class Cat : Animal {}
    public class Dog : Animal {}
    public class Stack<T> : IPoppable<T>, IPushable<T>
    {
        public int Size { get => data.Count; }
        public bool Empty { get => data.Count == 0; }
        private List<T> data;
        public Stack() => data = new List<T>();
        public Stack(IEnumerable<T> data) => this.data = new List<T>(data);

        public void Push (T obj) => data.Add(obj);
        public T Pop()
        {
            if(Empty)
                throw new IndexOutOfRangeException("Stack is empty");
            
            T item = data[data.Count -1];
            data.RemoveAt(data.Count -1);
            return item;
        }
    }
    public class AnimalCleaner
    {
        //public static void Wash(Stack<Animal> animals)
        public static void Wash(IPoppable<Animal> animals)
        {
            System.Console.WriteLine("The animals are clean!");
        }
    }
    class Program
    {
        public static void Main()
        {
            Stack<Dog> dogs = new Stack<Dog>();
            //Stack<Animal> animals = dogs; //error CS0029
            //AnimalCleaner.Wash(dogs); // error CS1503

            dogs.Push(new Dog());
            IPoppable<Animal> animals = dogs;
            AnimalCleaner.Wash(animals);

            ////////////////////////////////////////////////////
            IPushable<Animal> animals2 = new Stack<Animal>();
            IPushable<Dog> dogs2 = animals2;
            dogs2.Push(new Dog());
        }
    }
}