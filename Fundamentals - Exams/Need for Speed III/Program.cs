using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string car = string.Empty;
            int mileage = 0;
            int availableFuel = 0;

            var cars = new Dictionary<string, List<int>>(2);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                car = input[0];
                mileage = int.Parse(input[1]);
                availableFuel = int.Parse(input[2]);


                if (!cars.ContainsKey(car))
                {
                    cars.Add(car, new List<int>());

                }
                cars[car].Add(mileage);
                cars[car].Add(availableFuel);

            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(" : ");

                if (command[0] == "Stop")
                {
                    break;
                }

                if (command[0] == "Drive")
                {
                    car = command[1];
                    int currentDistance = int.Parse(command[2]);
                    int currentFuel = int.Parse(command[3]);

                    if (cars[car][1] < currentFuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        Console.WriteLine($"{car} driven for {currentDistance} kilometers. {currentFuel} liters of fuel consumed.");
                        cars[car][0] += currentDistance;
                        cars[car][1] -= currentFuel;
                        if (cars[car][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }
                    }

                }

                if (command[0] == "Refuel")
                {
                    car = command[1];
                    int currentFuel = int.Parse(command[2]);
                    if (cars[car][1] + currentFuel >= 75)
                    {
                        Console.WriteLine($"{car} refueled with {75 - cars[car][1]} liters");
                        cars[car][1] = 75;
                    }
                    else
                    {
                        cars[car][1] += currentFuel;
                        Console.WriteLine($"{car} refueled with {currentFuel} liters");
                    }
                }

                if (command[0] == "Revert")
                {
                    car = command[1];
                    int kilometers = int.Parse(command[2]);


                    if (cars[car][0] - kilometers < 10000)
                    {
                        cars[car][0] = 10000;
                    }
                    else
                    {
                        cars[car][0] -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }

            }
            foreach (var kvp in cars.OrderByDescending(kvp => kvp.Value[0]).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value[0]} kms, Fuel in the tank: {kvp.Value[1]} lt.");
            }

        }
    }
}
