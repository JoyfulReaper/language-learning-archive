namespace StructDemo
{
    public struct Point
    {
        int x, y; // No field initializers allowed
        //int z = 1; <- Field initialzer, not allowed

        public Point(int x, int y)
        {
            // All Fields MUST be assigned
            this.x = x;
            this.y = y;
        }

        public override string ToString() 
        {
            return $"{x},{y}";
        }
    }
    class Program
    {
        public static void Main()
        {
            Point p1 = new Point(); // parameterless constructor implicitly exisits -> Bitwise zero of all fields
            Point p2 = new Point(1,2);

            System.Console.WriteLine($"p1: {p1}");
            System.Console.WriteLine($"p2: {p2}");
        }
    }
}