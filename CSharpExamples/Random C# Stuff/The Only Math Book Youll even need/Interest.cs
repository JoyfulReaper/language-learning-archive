using System;

namespace OnlyMath
{
    public class Interest
    {
        public static void Main()
        {
            while(true)
            {
                Console.WriteLine("\nInterest Calculators");
                Console.WriteLine("1. Simple interest");
                Console.WriteLine("2. Compound Interest");
                Console.WriteLine("3. Quit");
                var option = OnlyMathLib.RequireValidDecimal("\nOption: ");

                switch (option)
                {
                    case 1:
                        CalculateSimpleInterest();
                        break;
                    case 2:
                        CalculateCompoundInterest();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }
            }
        }

        private static decimal SimpleInterest(decimal principal, decimal rate, decimal years)
        {
            return principal * rate * years;
        }

        private static decimal CompoundInterest(decimal principal, decimal rate, decimal freq, decimal years)
        {
            Console.WriteLine($"Principal: {principal}, Rate: {rate}, Frequency:{freq}, years:{years}");
            var finalAmount = principal * (decimal) Math.Pow( 1 + (double) (rate / freq) , (double) (freq * years ) );
            return (decimal)finalAmount - principal;
        }

        private static void CalculateSimpleInterest()
        {
            Console.WriteLine();
            var principal = OnlyMathLib.RequireValidDecimal("Principal Amount: ");
            var rate = OnlyMathLib.RequireValidDecimal("Interest rate: ");
            var years = OnlyMathLib.RequireValidDecimal("Years: ");

            var interest = SimpleInterest(principal, rate / 100, years);

            Console.WriteLine();
            OnlyMathLib.ColorWriteLine($"Interest: {interest:N2} Principal + Interest: {interest + principal:N2}");
        }

        private static void CalculateCompoundInterest()
        {
            Console.WriteLine();
            var principal = OnlyMathLib.RequireValidDecimal("Principal Amount: ");
            var rate = OnlyMathLib.RequireValidDecimal("Interest rate: ");
            var years = OnlyMathLib.RequireValidDecimal("Years: ");
            var frequency = OnlyMathLib.RequireValidDecimal("Times compounded per year: ");

            var interest = CompoundInterest(principal, rate / 100, frequency, years);

            Console.WriteLine();
            OnlyMathLib.ColorWriteLine($"Interest: {interest:N2} Principal + Interest: {interest + principal:N2}");
        }
    }
}