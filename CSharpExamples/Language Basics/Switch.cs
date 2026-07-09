// Example of use of switch statement based on:
// C# 7 in a Nutshell pg 65
using System;

class SwitchTest
{
    public static void Main()
    {
        int cardNum;
        string cardNumString;

        do {
            Console.Write("Enter a number between 1 and 13 inclusive: ");
            cardNumString = Console.ReadLine();

            if(cardNumString.ToUpper() == "J")
            {
                cardNum = -1;
                break;
            }

        } while ( !Int32.TryParse(cardNumString, out cardNum)  || cardNum < 1 || cardNum > 13);

        Console.WriteLine("That card is: ");

        switch (cardNum)
        {
            case 13:
                Console.WriteLine("King");
                break;
            case 12:
                Console.WriteLine("Queen");
                break;
            case 11:
                Console.WriteLine("Jack");
                break;
            case -1:
                Console.Write("Joker, same value as: ");
                goto case 12;
            default:
                Console.WriteLine("Not a face card: {0}", cardNum);
                break;
        }
    }
}