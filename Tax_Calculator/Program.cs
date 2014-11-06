using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a dollar value: ");
            string userInput = Console.ReadLine();
            decimal dollarValue;
            while (!decimal.TryParse(userInput, out dollarValue))
            {
                Console.WriteLine("You've entered an invalid input.\n");
                Console.Write("Please enter a dollar value: ");
                userInput = Console.ReadLine();
            }

            Console.Write("Please enter the current tax percentage: ");
            userInput = Console.ReadLine();
            decimal taxPercentage;
            while (!decimal.TryParse(userInput, out taxPercentage))
            {
                Console.WriteLine("You've entered an invalid input.\n");
                Console.Write("Please enter the current tax percentage: ");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("\nSubtotal: {0:C}", dollarValue);
            decimal tax = CalculateTax(taxPercentage, dollarValue);
            Console.WriteLine("Tax: {0:C}", tax);
            Console.WriteLine("-------------------");
            Console.WriteLine("Grand Total: {0:C}\n", dollarValue + tax);
        }

        private static decimal CalculateTax(decimal taxPercentage, decimal dollarValue)
        {
            return dollarValue * taxPercentage / 100;
        }
    }


}
