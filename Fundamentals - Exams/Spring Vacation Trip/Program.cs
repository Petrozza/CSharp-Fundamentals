using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int countOfPeople = int.Parse(Console.ReadLine());
            double PriceOfFuelPerKM = double.Parse(Console.ReadLine());
            double foodExpencesPerPerson = double.Parse(Console.ReadLine());
            double priceForRoomPerDay = double.Parse(Console.ReadLine());

            double totalFoodExpences = days * countOfPeople * foodExpencesPerPerson;
            double totalRoomExpences = 0;

            if (countOfPeople > 10)
            {
                totalRoomExpences = (days * countOfPeople * priceForRoomPerDay) * 0.75;
            }
            else
            {
                totalRoomExpences = days * countOfPeople * priceForRoomPerDay;
            }

            double currentExpences = totalFoodExpences + totalRoomExpences; //1050
            double consumedfuelPerDay = 0;

            for (int day = 1; day <= days; day++)
            {
                double dailyTrip = double.Parse(Console.ReadLine());
                consumedfuelPerDay = PriceOfFuelPerKM * dailyTrip; //768
                currentExpences += consumedfuelPerDay;
                if (currentExpences > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {currentExpences - budget:f2}$ more.");
                    return;
                }

                if (day % 3 == 0 || day % 5 == 0)
                {
                    currentExpences += currentExpences * 0.4; //420
                    if (currentExpences > budget)
                    {
                        Console.WriteLine($"Not enough money to continue the trip. You need {currentExpences - budget:f2}$ more.");
                        return;
                    }
                }

                if (day % 7 == 0)
                {
                    currentExpences -= (currentExpences / countOfPeople); //210
                }
            }
            if (currentExpences > budget)
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {currentExpences - budget:f2}$ more.");
            }
            else
            {
                Console.WriteLine($"You have reached the destination. You have {budget - currentExpences:f2}$ budget left.");
            }
        }
    }
}

