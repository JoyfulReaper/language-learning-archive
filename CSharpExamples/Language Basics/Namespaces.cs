// Namespace example
using Outer.Middle.Inner;

namespace Outer.Middle.Inner
{
    class Class1 {}
    class Class2 {}
}

namespace Outer // More verbose version of above
{
    namespace Middle 
    {
        namespace Inner2
        {
            class Class3 {}
        }
    }
}

class Test
{
    static void Main()
    {
        // using directive above allows us to not have to use the fully qualified name
        Class1 c1 = new Class1();
        Class2 c2 = new Class2();
        System.Console.WriteLine("Created c1, c2");

        // Using the fully qualified name
        Outer.Middle.Inner2.Class3 c3 = new Outer.Middle.Inner2.Class3();
        System.Console.WriteLine("Created c3");
    }
}