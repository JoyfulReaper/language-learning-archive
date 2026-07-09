using System;
public class Program {
    public struct Note : IComparable<Note>, IEquatable<Note>, IComparable
    {
        int semitonesFromA;
        public int SemitonesFromA { get { return semitonesFromA; }}

        public Note (int semitonesFromA) => this.semitonesFromA = semitonesFromA;

        public int CompareTo (Note other) // Generic IComparable<T>
        {
            if (Equals (other)) return 0;
            return semitonesFromA.CompareTo (other.semitonesFromA);
        }

        int IComparable.CompareTo(object other) // Non-generic IComparable
        {
            if(!(other is Note))
                throw new InvalidOperationException("CompareTo: Not a note!");
            return CompareTo ((Note) other);
        }

        public static bool operator < (Note n1, Note n2) => n1.CompareTo(n2) < 0;

        public static bool operator > (Note n1, Note n2) => n1.CompareTo(n2) > 0;

        public bool Equals (Note other) // For IEquatable<Note>
            => semitonesFromA == other.semitonesFromA;

        public override bool Equals (object other)
        {
            if(!(other is Note)) return false;
            return Equals((Note) other);
        }

        public override int GetHashCode() => SemitonesFromA.GetHashCode();

        public static bool operator == (Note n1, Note n2) => n1.Equals(n2);

        public static bool operator != (Note n1, Note n2) => !(n1 == n2);

        public static Note operator + (Note x, int semitones) => new Note(x.SemitonesFromA + semitones);

        public override string ToString() => $"Semitones from A: {SemitonesFromA}";
    }
    public static void Main() { 
        Note B = new Note (2);
        Note CSharp = B + 2;

        Console.WriteLine("B: {0}", B);
        Console.WriteLine("CSharp {0}", CSharp);

        Note AlsoCSharp = new Note(CSharp.SemitonesFromA);
        Console.WriteLine("AlsoCSharp == CSharp: {0}", AlsoCSharp == CSharp);
        Console.WriteLine("B < CSharp: {0}", B < CSharp);
        Console.WriteLine("B > CSharp: {0}", B > CSharp);
        Console.WriteLine();

        Console.WriteLine("B.ComparTo(CSharp): {0}", B.CompareTo(CSharp));
        Console.WriteLine("CSharp.ComparTo(B): {0}", CSharp.CompareTo(B));
        Console.WriteLine("CSharp.ComparTo(CSharp): {0}", CSharp.CompareTo(CSharp));
    }
}