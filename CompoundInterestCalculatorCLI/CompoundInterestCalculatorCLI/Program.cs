using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterestCalculatorCLI
{
    class Program
    {
        // Balance(Y)   =   P(1 + r)Y   +   c[ ((1 + r)Y + 1 - (1 + r)) / r ]

        private double total;
        private string principal;
        private string interest;
        private string years;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetValues();
            p.total = p.CalculateInterest();

            Console.WriteLine("Future Value: " + p.total.ToString("C2"));
            Console.ReadLine();
        }

        private void GetValues()
        {
            Console.Write("Principal: ");
            principal = Console.ReadLine();

            Console.Write("Interest Rate (As Decimal): ");
            interest = Console.ReadLine();

            Console.Write("Years to Compound: ");
            years = Console.ReadLine();
        }

        private double CalculateInterest()
        {
            total = double.Parse(principal) * Math.Pow((1 + (double.Parse(interest) / 1)), (1 * int.Parse(years)));
            return total;
        }
    }
}