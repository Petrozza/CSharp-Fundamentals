using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split().ToArray();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            double sumCarsPower = 0;
            double sumTrucksPower = 0;

            while (command[0] != "End")
            {
                string type = command[0];
                string model = command[1];
                string color = command[2];
                int horsePower = int.Parse(command[3]);

                if (type == "car")
                {
                    Car car = new Car(type, model, color, horsePower);
                    cars.Add(car);
                }
                else if (type == "truck")
                {
                    Truck truck = new Truck(type, model, color, horsePower);
                    trucks.Add(truck);
                }
                command = Console.ReadLine().Split().ToArray();
            }

            string modelsInput = Console.ReadLine();
            while (modelsInput != "Close the Catalogue")
            {

                if (cars.Exists(cars => cars.Model == modelsInput))
                {
                    //закоментираното е за решенение без стрингбилдър
                    //int index = cars.FindIndex(cars => cars.Model == modelsInput);
                    Console.WriteLine(cars.Find(cars => cars.Model == modelsInput));
                    //Console.WriteLine($"Type: Car");
                    //Console.WriteLine($"Model: {cars[index].Model}");
                    //Console.WriteLine($"Color: {cars[index].Color}");
                    //Console.WriteLine($"Horsepower: {cars[index].HorsePower}");
                }

                if (trucks.Exists(trucks => trucks.Model == modelsInput))
                {
                    //int index = trucks.FindIndex(trucks => trucks.Model == modelsInput);
                    Console.WriteLine(trucks.Find(trucks => trucks.Model == modelsInput));
                    // Console.WriteLine($"Type: Truck");
                    //Console.WriteLine($"Model: {trucks[index].Model}");
                    //Console.WriteLine($"Color: {trucks[index].Color}");
                    //Console.WriteLine($"Horsepower: {trucks[index].HorsePower}");
                }

                modelsInput = Console.ReadLine();

            }
            foreach (var item in cars)
            {
                sumCarsPower = cars.Sum(c => c.HorsePower);
            }

            foreach (var item in trucks)
            {
                sumTrucksPower = trucks.Sum(t => t.HorsePower);
            }

            if (cars.Count > 0)
            {
                double averageCarPower = sumCarsPower / cars.Count;
                Console.WriteLine($"Cars have average horsepower of: {averageCarPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {

                double averageTruckPower = sumTrucksPower / trucks.Count;
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }

        public class Car
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

            public Car(string type, string model, string color, int horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }

            public override string ToString()
            {

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Type: " + Type.Remove(1).ToUpper() + Type.Substring(1));
                sb.AppendLine("Model: " + Model);
                sb.AppendLine("Color: " + Color);
                sb.AppendLine("Horsepower: " + HorsePower);

                return sb.ToString().TrimEnd();
            }
        }

        public class Truck
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

            public Truck(string type, string model, string color, int horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsepower;
            }

            public override string ToString()
            {

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Type: " + Type.Remove(1).ToUpper() + Type.Substring(1));
                sb.AppendLine("Model: " + Model);
                sb.AppendLine("Color: " + Color);
                sb.AppendLine("Horsepower: " + HorsePower);

                return sb.ToString().TrimEnd();
            }

        }


    }
}

