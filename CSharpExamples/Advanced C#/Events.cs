namespace EventExample
{
    public delegate void PriceChangedHandler (decimal oldPrice, decimal newPrice);
    
    public class Stock
    {
        string symbol;
        decimal price;

        public Stock (string symbol) { this.symbol = symbol;}

        public event PriceChangedHandler PriceChanged;

        public decimal Price{
            get { return price;}
            set
            {
                if(price == value) return;
                decimal oldPrice = price;
                price = value;
                if(PriceChanged != null)
                    PriceChanged(oldPrice, price);
            }
        }
    }

    public class Progam
    {
        public static void Main()
        {
            Stock planEx = new Stock("PLNX");
            planEx.PriceChanged += priceChanged;
            planEx.Price = 100;
            planEx.Price = 30;
            planEx.Price = 55;
            planEx.Price = 4;
        }

        public static void priceChanged(decimal oldPrice, decimal newPrice)
        {
            System.Console.WriteLine($"Price changed: Old: {oldPrice} New: {newPrice}");
        }
    }
}