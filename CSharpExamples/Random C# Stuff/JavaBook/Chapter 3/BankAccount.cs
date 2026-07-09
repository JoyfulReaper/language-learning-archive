using System;
public class BankAccount
{
    public decimal Balance { get; private set; }
    public BankAccount()
    {
        Balance = 0;
    }

    public BankAccount(decimal initalBalance)
    {
        if (initalBalance < 0)
        {
            throw new ArgumentException("initalBalance must be non-negative.");
        }

        Balance = initalBalance;
    }

    public void deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("amount must be non-negative");
        }

        Balance += amount;
    }

    public void withdraw(decimal amount)
    {
        if(amount < 0)
        {
            throw new ArgumentException("amount must be non-negative");
        }
        if(amount > Balance)
        {
            throw new ArgumentException("amount cannot be greater than balance");
        }
        Balance -= amount;
    }

    public static void Main()
    {
        BankAccount b = new BankAccount(10);
        Console.WriteLine($"Balance: {b.Balance}");
    }

}