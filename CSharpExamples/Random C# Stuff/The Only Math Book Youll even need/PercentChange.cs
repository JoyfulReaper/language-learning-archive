using System;

namespace OnlyMath
{
    public class Percent
    {
        public static void Main()
        {
            decimal change = 0;
            decimal baseAmount = 0;

            while (true)
            {
                Console.WriteLine("\nPercent Change");
                Console.WriteLine("1. Enter change and base amount");
                Console.WriteLine("2. Enter new amount and old amount");
                Console.WriteLine("3. Enter percentage of change");
                Console.WriteLine("4. Quit");
                var option = RequireValidDecimal("\nOption: ");

                if (option < 1 || option > 4)
                {
                    continue;
                }

                if (option == 4)
                {
                    Environment.Exit(0);
                }

                if (option == 1)
                {
                    change = RequireValidDecimal("Enter amount of change: ");
                    baseAmount = RequireValidDecimal("Enter base amount: ");

                    Console.WriteLine();
                    var percentChange = PercentChange(change, baseAmount);
                    OnlyMathLib.ColorWriteLine($"{baseAmount + change} is an increase of {percentChange * 100:N2}% from {baseAmount}");
                    OnlyMathLib.ColorWriteLine($"{baseAmount - change} is a decrease of {percentChange * 100:N2}% from {baseAmount}");
                }

                if (option == 2)
                {
                    var newAmount = RequireValidDecimal("Enter new amount: ");
                    baseAmount = RequireValidDecimal("Enter old amount: ");
                    change = Math.Abs(newAmount - baseAmount);

                    var message = newAmount > baseAmount ? "increase" : "decrease";

                    Console.WriteLine();
                    var percentChange = PercentChange(change, baseAmount);
                    OnlyMathLib.ColorWriteLine($"{newAmount} is an {message} of {percentChange * 100:N2}% from {baseAmount}");
                }

                if (option == 3)
                {
                    baseAmount = RequireValidDecimal("Enter base amount: ");
                    var percentChange = RequireValidDecimal("Enter percent change: ");
                    change = percentChange * baseAmount / 100;

                    Console.WriteLine();
                    OnlyMathLib.ColorWriteLine($"{change + baseAmount} is an increase of {percentChange}%");
                    OnlyMathLib.ColorWriteLine($"{baseAmount - change} is a decrease of {percentChange}%");
                }
            }
        }

        private static decimal RequireValidDecimal(string prompt)
        {
            bool valid = false;
            decimal result = 0;
            while (!valid)
            {
                Console.Write(prompt);
                valid = Decimal.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

        private static decimal PercentChange(decimal amountOfChange, decimal baseAmount)
        {
            return (amountOfChange / baseAmount) * 1.0m;
        }
    }
}