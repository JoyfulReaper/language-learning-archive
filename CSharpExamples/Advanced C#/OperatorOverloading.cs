// Operator overloading example
// Implicit and Explict operator examples (casting)

using System;
class Program
{
    public struct Note
    {
        int value;
        public Note (int semitonesFromA) { value = semitonesFromA; }

        // must be public static. operator keyword then operator symbol to overload
        public static Note operator + (Note x, int semitones) => new Note(x.value + semitones);

        // I think this isn't working now becasue the implicit conversion to double to overriding this ToString()
        public override string ToString() => $"Value: {value}";
        
        // Implicit and Explicity conversions
        //Convert to hertz
        public static implicit operator double (Note x)
            => 440 * Math.Pow(2, (double) x.value / 12);

        // convert from hertz (accurate to nearest semitone)
        public static explicit operator Note (double x)
            => new Note((int) (0.5 + 12 * (Math.Log(x/440) / Math.Log(2) )));
    }
    public static void Main()
    {
        Note B = new Note (2);
        Note CSharp = B + 2;

        Console.WriteLine(B);
        Console.WriteLine(CSharp);

        Console.WriteLine();
        Note n = (Note)554.37;
        double x = n;
        Console.WriteLine(n);
        Console.WriteLine(x);
    }
}