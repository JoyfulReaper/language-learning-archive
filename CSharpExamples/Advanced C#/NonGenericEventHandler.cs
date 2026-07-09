// Example of the Standard Event Pattern
// Using non-generic EventHandler delegate.
// This can be used when you just need to know an event happened, there is no data associated with it
// 1. Sse Framework define delegate:
//      System.EventHandler
// 2. Define an event of the given delegate type
// 3. protected virtual method that fire the event, name must match name of event prefix by On

using System;
namespace EventPattern
{
    public class Stock
    {
        string symbol;
        decimal price;

        public Stock (string symbol) { this.symbol = symbol;}

        public event EventHandler PriceChanged; // Use Framework defined non-generic delegate

        protected virtual void OnPriceChanged(EventArgs e) // Protected Virtual Method that fires the event
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price{
            get { return price;}
            set
            {
                if(price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(EventArgs.Empty); // Trigger the event
            }
        }
    }

    public class Progam
    {
        public static void Main()
        {
            Stock stock = new Stock("PLNX");
            stock.Price = 37.10M;

            stock.PriceChanged += stock_PriceChanged; // Register with the event
            stock.Price = 33.95M;
            stock.Price = 45.97M;
        }

        static void stock_PriceChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("The price changed!");
        }
    }
}