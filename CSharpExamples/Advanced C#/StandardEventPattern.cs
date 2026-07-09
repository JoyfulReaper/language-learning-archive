// Example of the Standard Event Pattern
//
// 1. Subclass System.EventArgs to convey the event infomration
// 2. Define a delegate following the 3 rules (C#7 in a nutshell pg 149) or use Framework defined generic delegate:
//      System.EventHandler<>
// 3. Define an event of the given delegate type
// 4. protected virtual method that fire the event, name must match name of event prefix by On
//

using System;

namespace EventPattern
{
    // Step one: Subclass System.EventArgs to convery event's information
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }

    public class Stock
    {
        string symbol;
        decimal price;

        public Stock (string symbol) { this.symbol = symbol;}

        public event EventHandler<PriceChangedEventArgs> PriceChanged; // 2 & 3 Use Framework define generic delegate

        protected virtual void OnPriceChanged(PriceChangedEventArgs e) // Protected Virtual Method that fires the event
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
                OnPriceChanged(new PriceChangedEventArgs (oldPrice, price)); // Trigger the event
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

        static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            System.Console.WriteLine($"Price changed: Old: {e.LastPrice} New: {e.NewPrice}");
            if((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                System.Console.WriteLine("Price increased 10%!");
        }
    }
}