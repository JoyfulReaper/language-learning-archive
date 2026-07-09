namespace GenericDelegate
{
    public delegate T Transformer<T> (T arg); // Generic delegate

    class Util
    {
        public static void Transform<T> (T[] values, Transformer<T> t)
        {
            for(int i = 0; i < values.Length; i++)
                values[i] = t(values[i]);
        }
    }

    class Program
    {
        public static void Main()
        {
            int[] values = { 1, 2, 3 };
            string[] stringVals = { "one", "two", "three" };

            //Util.Transform(values, Square); // Hook in Square
            Util.Transform(values, AddOne); // Hook in AddOne
            Util.Transform(stringVals, AddOne); // Hook in AddOne

            foreach(int i in values)
                System.Console.WriteLine(i + " ");

            foreach(string s in stringVals)
                System.Console.WriteLine(s + " ");
        }

        static int Square(int x) => x * x;
        static int AddOne(int x) => x + 1;
        static string AddOne(string x) => x + "1";
    }
}