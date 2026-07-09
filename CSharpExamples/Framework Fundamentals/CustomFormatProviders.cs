// Implementing custom format providers

using System;
using System.Globalization;
using System.Text;
class Program
{
    public class YellingFormatProvider : IFormatProvider, ICustomFormatter
    {
        IFormatProvider parent;

        public YellingFormatProvider() : this (CultureInfo.CurrentCulture) {}
        public YellingFormatProvider(IFormatProvider parent) => this.parent = parent;

        public object GetFormat(Type formatType)
        {
            if(formatType == typeof(ICustomFormatter)) return this;
            return null;
        }

        public string Format(string format, object arg, IFormatProvider prov)
        {
            if (arg == null || format != "Y")
                return string.Format(parent, "{0:" + format + "}", arg);

            return arg.ToString().ToUpper();
        }
    }

    public class WordyFormatProvider : IFormatProvider, ICustomFormatter
    {
        static readonly string[] numberWords = 
            "zero one two three four five six seven eight nine minus point".Split();
        IFormatProvider parent;

        public WordyFormatProvider () : this (CultureInfo.CurrentCulture) {}
        public WordyFormatProvider (IFormatProvider parent) => this.parent = parent;

        public object GetFormat(Type formatType) 
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            return null;
        }

        public string Format (string format, object arg, IFormatProvider prov)
        {
            // Not our format string, defer to parent provider
            if(arg == null || format != "W")
                return string.Format(parent, "{0:}" + format + "}", arg);

            StringBuilder result = new StringBuilder();
            string digitList = string.Format(CultureInfo.InvariantCulture, "{0}", arg);

            foreach (char digit in digitList)
            {
                int i = "0123456789-.".IndexOf(digit);
                if(i == -1)
                    continue;
                
                if(result.Length > 0)
                    result.Append(' ');
                
                result.Append(numberWords[i]);
            }
            return result.ToString();
        }

    } 
    public static void Main()
    {
        IFormatProvider yell = new YellingFormatProvider();
        IFormatProvider wordy = new WordyFormatProvider();
        Console.WriteLine(string.Format(yell, "it is a {0:Y} day outside", "nice"));

        Console.WriteLine("\nEnter a number");
        string res = Console.ReadLine();
        Console.WriteLine(string.Format(wordy, "{0:W}", res));
    }
}