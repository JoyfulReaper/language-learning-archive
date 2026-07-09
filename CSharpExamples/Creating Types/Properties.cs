using System;

public class Stock
{
    decimal currentPrice; // Private backing field
    decimal sharesOwned;

    public decimal CurrentPrice // Property
    {
        get { return currentPrice; } // get accessor
        set { currentPrice = value; } // set accessor
    }

    public String OwnerName { get; set; } // Automatic property
    // Compiler generates private backing field.

    // Read only calculated property:
    //public decimal Worth
    //{
    //    get { return currentPrice * sharesOwned; }
    //}

    // C# 6+ expression-bodied calculated property
    // public decimal Worth => currentPrice * sharesOwned; 

    // C#7 get and set accessors expression-bodied
    public decimal Worth
    {
        get => currentPrice * sharesOwned;
        set => sharesOwned = value / currentPrice;
    }

    public static void Main()
    {
        Stock msft = new Stock();
        msft.CurrentPrice = 30;
        msft.CurrentPrice -= 3;
        msft.sharesOwned = 20;
        msft.OwnerName = "Sam Somone";
        Console.WriteLine("Current Price: {0}", msft.CurrentPrice);
        Console.WriteLine($"Shares owned: {msft.sharesOwned} Worth: {msft.Worth} Owner: {msft.OwnerName}");
    }
}