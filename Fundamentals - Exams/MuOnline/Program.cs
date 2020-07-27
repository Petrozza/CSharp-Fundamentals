using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split(' ', '|');
            string command = " ";
            int number = 0;
            int health = 100;
            int bitcoins = 0;
            bool killed = false;

            for (int i = 0; i < rooms.Length; i += 2)
            {
                command = rooms[i];
                number = int.Parse(rooms[i + 1]);

                switch (command)
                {
                    case "potion":
                        int originalHealth = health;
                        int healed = 0;
                        //health += number; //90+
                        if (health + number >= 100)
                        {
                            healed = 100 - health;
                            health = 100;
                        }
                        else
                        {
                            healed = number;
                            health += number;
                        }
                        Console.WriteLine($"You healed for {healed} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        bitcoins += number;
                        Console.WriteLine($"You found {number} bitcoins.");
                        break;
                    default:
                        health -= number; //100-10=90
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {command}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {((i + 1) / 2) + 1}");
                            killed = true;
                            break;
                        }
                        break;

                }
                if (killed)
                {
                    break;
                }
            }

            if (!killed)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }


    }
}
