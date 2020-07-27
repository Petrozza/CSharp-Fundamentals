using System;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    int number1 = numbers.ElementAt(index1);
                    int number2 = numbers.ElementAt(index2);

                    numbers[index2] = number1;
                    numbers[index1] = number2;

                }

                if (command[0] == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    int number1 = numbers.ElementAt(index1);
                    int number2 = numbers.ElementAt(index2);
                    if ((number1 * number2 < int.MaxValue) && (number1 * number2 > int.MinValue))
                    {
                        numbers[index1] = number1 * number2;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (command[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int number = numbers[i];
                        numbers[i] = number - 1;
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

