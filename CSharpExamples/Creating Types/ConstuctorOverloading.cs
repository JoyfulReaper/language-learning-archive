using System;

public class Wine
{
    public decimal price;
    public int year;
    public Wine(decimal price) => this.price = price;
    public Wine(decimal price, int year) : this (price) => this.year = year;

    public static void Main()
    {
        Wine wineOne = new Wine(99.99m);
        Wine wineTwo = new Wine(49.99m, 1955);

        Console.WriteLine($"WineOne: Price: {wineOne.price} Year: {wineOne.year}");
        Console.WriteLine($"WineTwo: Price: {wineTwo.price} Year: {wineTwo.year}");
    }

}