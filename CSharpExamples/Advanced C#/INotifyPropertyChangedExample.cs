using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Foo : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged = delegate { }; // Default empty delagate

    void RaisePropertyChanged ([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private string customerName;
    string CustomerName
    {
        get { return customerName; }
        set 
        {
            if (value == customerName) return;
            customerName = value;
            RaisePropertyChanged();
        }
    }

    public class Program
    {
        public static void Main()
        {
            Foo f = new Foo();
            f.PropertyChanged += Foo_PropertyChanged;
            f.CustomerName = "Mr. Smith";
            f.CustomerName = "Mrs. Smith";
        }

        private static void Foo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Foo ff = (Foo)sender;
            Console.WriteLine($"{e.PropertyName} changed");
            Console.WriteLine($"Changed to: {ff.CustomerName}");
        }
    }
}