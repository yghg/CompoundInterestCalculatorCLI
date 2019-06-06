using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterestCalculatorCLI
{
    class Program
    {
        // variables
        private double compound;
        private string txtPrincipal;
        private double principal;
        private string txtInterest;
        private double interest;
        private string txtYears;
        private int years;

        static void Main(string[] args)
        {            
            Console.WriteLine("SIMPLE COMPOUND INTEREST CALCULATOR");
            Console.WriteLine("");

            Program p = new Program();
            p.GetValues();
            p.compound = p.CalculateInterest();

            Console.WriteLine("");
            Console.WriteLine("Future Value: " + p.compound.ToString("C2"));
            Console.WriteLine("");
            Console.WriteLine("(PRESS ANY KEY TO EXIT)");
            Console.ReadLine();
        }

        // get and validate input from user
        private void GetValues()
        {
            try
            {
                Console.Write("Principal: ");
                txtPrincipal = Console.ReadLine();
                bool isDoubleP = Double.TryParse(txtPrincipal, out principal);
                while (!isDoubleP)
                {
                    Console.Write("Principal: ");
                    txtPrincipal = Console.ReadLine();
                    isDoubleP = Double.TryParse(txtPrincipal, out principal);
                    continue;
                }
                principal = double.Parse(txtPrincipal);

                Console.Write("Interest Rate (As Decimal): ");
                txtInterest = Console.ReadLine();
                bool isDoubleI = Double.TryParse(txtInterest, out interest);
                while (!isDoubleI)
                {
                    Console.Write("Interest Rate (As Decimal): ");
                    txtInterest = Console.ReadLine();
                    isDoubleI = Double.TryParse(txtInterest, out interest);
                    continue;
                }
                interest = double.Parse(txtInterest);

                Console.Write("Years to Compound: ");
                txtYears = Console.ReadLine();
                bool isDoubleY = int.TryParse(txtYears, out years);
                while (!isDoubleY)
                {
                    Console.Write("Years to Compound: ");
                    txtYears = Console.ReadLine();
                    isDoubleY = int.TryParse(txtYears, out years);
                    continue;
                }
                years = int.Parse(txtYears);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                throw;
            }
            
        }

        // do the math
        // compound = principal(1 + (interest/n)^(n*years))
        private double CalculateInterest()
        {
            try
            {
                compound = (principal * Math.Pow((1 + (interest / 1)), (1 * years)));
                return compound;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                throw;
            }            
        }
    }
}