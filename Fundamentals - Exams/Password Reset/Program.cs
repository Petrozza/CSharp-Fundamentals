using System;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Done")
                {
                    break;
                }

                switch (command[0])
                {
                    case "TakeOdd":
                        string result = "";
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (i %2 != 0)
                            {
                                result += text[i];
                            }
                        }
                        text = result.ToString();
                        Console.WriteLine(text);
                        break;

                    case "Cut":
                        int index = int.Parse(command[1]);
                        int length = int.Parse(command[2]);
                        text = text.Remove(index, length).ToString();
                        Console.WriteLine(text);
                        break;

                    case "Substitute":
                        string substring = command[1];
                        string substitute = command[2];

                        if (text.Contains(substring))
                        {
                            text = text.Replace(substring, substitute);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }
            Console.WriteLine($"Your password is: {text}");
        }
    }
}
