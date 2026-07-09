// Examples of Eqality Protocols

namespace EqualityExamples
{
    public class Program
    {
        public static void Main()
        {
            // == and != 
            // Are staticly resolved operators
            // Compile time descion as to what type to use
            int a = 10;
            int b = 10;
            System.Console.WriteLine(a == b); // true (value equality)

            object y = 10;
            object x = 10;
            System.Console.WriteLine(x == y); // false (reference equality)

            // virtual bool object.Equals(object o)
            // Resolved at run time
            System.Console.WriteLine(y.Equals(x)); // true

            // static bool Equals(object a, object b)
            // null-safe equality comparision for when types are unknown at compile time
            System.Console.WriteLine(object.Equals(x, y)); // true

            // static bool ReferenceEquals(object a, object b)
            // Force referential equality
            object z = y;
            System.Console.WriteLine(object.ReferenceEquals(x, y)); // false
            System.Console.WriteLine(object.ReferenceEquals(z, y)); // true
            System.Console.WriteLine();
        }
    }
}