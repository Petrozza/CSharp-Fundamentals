using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Catalog catalog = new Catalog();
            catalog.Trucks = new List<Truck>();
            catalog.Cars = new List<Car>();

            while (line != "end")
            {
                string[] data = line.Split('/');

                string type = data[0];
                string brand = data[1];
                string model = data[2];
                string horsePower = data[3];
                string weight = data[3];

                if (type == "Truck")
                {
                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    catalog.Trucks.Add(truck);
                }

                else
                {
                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    catalog.Cars.Add(car);
                }

                line = Console.ReadLine();
            }

            List<Car> carsSorted = catalog.Cars.OrderBy(c => c.Brand).ToList();
            List<Truck> trucksSorted = catalog.Trucks.OrderBy(t => t.Brand).ToList();

            if (carsSorted.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in carsSorted)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (trucksSorted.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in trucksSorted)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    public class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
