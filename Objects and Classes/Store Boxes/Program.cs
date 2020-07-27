using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (command != "end")
            {
                string[] data = command.Split();

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                double PriceOfBox = itemQuantity * itemPrice;

                Box box = new Box();
                {
                    box.SerialNumber = serialNumber;
                    box.Item.Name = itemName;
                    box.ItemQuantity = itemQuantity;
                    box.PriceForABox = PriceOfBox;
                    box.Item.Price = itemPrice;
                }
                
                boxes.Add(box);
                command = Console.ReadLine();
            }
            List<Box> sortedList = boxes.OrderBy(o => o.PriceForABox).ToList();
            sortedList.Reverse();

            foreach (Box box in sortedList)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }

        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }

    }
}
