// Inheritance and Polymorphism example
// pg 96/97
// Stock and House inherit from Asset
// Virtual Function Members pg 100
// Functions marked virtual can be overriden by subclasses

using System;
public class Asset
{
    public string Name; // Name property is inherited by the  derived classes
    public virtual decimal Liability => 0; // Expression-bodied property
}

public class Stock : Asset // Inherits from Asset
{
    public long SharesOwned;
}

public class House : Asset
{
    public decimal Mortgage;
    public override decimal Liability => Mortgage;
}

public class Program
{
    public static void Main()
    {
         Stock msft = new Stock {Name = "MSFT", SharesOwned=1000};
         Console.WriteLine ("Name: {0}", msft.Name);
         Console.WriteLine ("Shares: {0}", msft.SharesOwned);
         Console.WriteLine ("Liability: {0}", msft.Liability);


         House mansion = new House { Name = "Mansion", Mortgage = 250_000};
         Console.WriteLine ("\nName: {0}", mansion.Name);
         Console.WriteLine ("Mortgage: {0}", mansion.Mortgage);
         Console.WriteLine ("Liability: {0}", mansion.Liability);


         Console.Write("\nName: ");
         Display(msft);
         Console.Write("Name: ");
         Display(mansion);


         Asset a = msft; // Upcast
         Console.WriteLine("\nAsset a Name: {0}", a.Name);
         // Console.WriteLine("Asset a SharesOwned: {0}", a.SharesOwned); - Not valid, Asset doesn't have SharesOwened Property

         Stock s = (Stock) a; // Downcast - Must be Explicit
         Console.WriteLine("Stock s SharesOwned: {0}", s.SharesOwned);

         Asset newAsset = new Asset();
         Stock newS = newAsset as Stock; // as performs a downcast that evaluates to null instead of failing
         if(newS == null)
            Console.WriteLine("Can't downcast from Asset to Stock");

        if (msft is Stock) // tests if a reference conversion will succeed
            Console.WriteLine(msft.Name + " is a stock");
    }

    public static void Display(Asset asset) // Polymorphism variable of type A can refer to an objec that subclasses A
    {
        Console.WriteLine(asset.Name);
    }
}