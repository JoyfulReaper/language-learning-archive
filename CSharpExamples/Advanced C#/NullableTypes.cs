class Program
{
    static void Main()
    {
        string s = null; // OK - Reference type
        // int i = null // Illegal value type
         int? i = null; // OK - Nullable type (? symbol)

         System.Console.WriteLine("int i is {0}", i == null ? "null" : "not null");

         int? x = 5; // Implicit conversion
         int y = (int)x; // Explict converison required, thows InvaildOperation if null (HasValue == false)
    }
}