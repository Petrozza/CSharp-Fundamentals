using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternCustomer = @"%[A-Z][a-z]+%"; 
            string patternProduct = @"<[\w]+>"; 
            string patternQuantity = @"[\|]\d+[\|]"; 
            string patternPrice = @"\d+\.?\d+\$"; 

            double totalSum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                Match customer = Regex.Match(input, patternCustomer);
                Match product = Regex.Match(input, patternProduct);
                Match quantity = Regex.Match(input, patternQuantity);
                Match price = Regex.Match(input, patternPrice);

                if (!(customer.Success && product.Success && quantity.Success && price.Success))
                {
                    continue;
                }

                string customerString = customer.Value;
                string productString = product.Value;
                string quantityString = quantity.Value;
                string priceString = price.Value;

                customerString = customerString.Substring(1, customerString.Length - 2);
                productString = productString.Substring(1, productString.Length - 2);
                quantityString = quantityString.Substring(1);
                int quantityDigit = int.Parse(quantityString = quantityString.Remove(quantityString.Length-1).ToString());
                double priceDigit = double.Parse(priceString.Remove(priceString.Length - 1).ToString());
                double sum = quantityDigit * priceDigit;
                totalSum += sum;
                Console.WriteLine($"{customerString}: {productString} - {sum:f2}");
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
