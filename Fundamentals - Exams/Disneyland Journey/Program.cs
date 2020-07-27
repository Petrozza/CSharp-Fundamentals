using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double savings = 0;

            savings = CalculateSavings(months, savings, journeyCost);

            if (savings >= journeyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {savings - journeyCost:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {journeyCost - savings:f2}lv. more.");
            }
        }

        static double CalculateSavings(int months, double saldo, double cost)
        {
            for (int i = 1; i <= months; i++)
            {
                if (i % 2 == 0 && i % 4 != 0 || i == 1)
                {
                    saldo += cost * 0.25;
                }

                if (i % 2 != 0 && i > 1)
                {
                    saldo -= saldo * 0.16;
                    saldo += cost * 0.25;
                }

                if (i % 4 == 0)
                {
                    saldo += saldo * 0.25;
                    saldo += cost * 0.25;
                }
            }
            return saldo;
        }
    }
}
