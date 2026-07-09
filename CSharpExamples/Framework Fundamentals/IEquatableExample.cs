// Its a good idea to implement IEquable<T> when overriding Equals

using System;
public struct Area : IEquatable<Area>
{
    public readonly int Measure1;
    public readonly int Measure2;
    public Area(int m1, int m2)
    {
        Measure1 = Math.Min(m1, m2);
        Measure2 = Math.Max(m1, m2);
    }

    public override bool Equals(object other)
    {
        if(!(other is Area)) return false;
        return Equals((Area) other); // Calls Equals() below
    }

    public bool Equals(Area other)  // Implments IEquatable<Area>
        => Measure1 == other.Measure1 && Measure2 == other.Measure2;

    public override int GetHashCode()
        => Measure2 * 31 + Measure1; // 31 = some prime number

    public static bool operator ==(Area a1, Area a2) => a1.Equals(a2);
    public static bool operator !=(Area a1, Area a2) => !a1.Equals(a2);

    public override string ToString()
    {
        return String.Format("{0} x {1}", Measure1, Measure2);
    }
}

public class Program
{
    public static void Main()
    {
        Area a1 = new Area(5,5);
        Area a2 = new Area(10,15);
        Area a3 = new Area(15, 10);
        System.Console.WriteLine(a1);
        System.Console.WriteLine(a2);
        System.Console.WriteLine(a3);
        System.Console.WriteLine();

        Console.WriteLine(a1 == a2);
        Console.WriteLine(a1.Equals(a2));

        Console.WriteLine(a3 == a2);
        Console.WriteLine(a3.Equals(a2));
    }
}