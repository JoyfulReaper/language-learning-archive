// using static allows all static members of a type to be used without being qualified
using static System.Console;

class Test
{
    static void Main()
    {
        Write("Enter some text: "); //System.Console.Write()
        string result = ReadLine(); // System.Console.ReadLine()
        WriteLine("You entered: {0}", result); // System.Console.WriteLine()
    }
}