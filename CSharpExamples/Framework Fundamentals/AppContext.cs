// Global String Keyed Dictionary of Boolean values: intended for library authors to switch new features on or off.

using System;
public class Program
{
    public static void Main()
    {
        AppContext.SetSwitch ("MyLibrary.SomeBreakingChange", true); // Consumer library requests SomeBreakingChange

        bool isDefined, switchValue;
        isDefined = AppContext.TryGetSwitch("MyLibrary.SomeBreakingChange", out switchValue);

        if(!isDefined)
            Console.WriteLine("MyLibrary.SomeBreakingChange is undefined");
        else
            Console.WriteLine("MyLibrary.SomeBreakingChange: {0}", switchValue);
    }
}