using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groce = Console.ReadLine().Split("!").ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "Go")
            {
                switch (command[0])
                {
                    case "Urgent":
                        AddItemAtStart(groce, command);
                        break;
                    case "Unnecessary":
                        RemoveItem(groce, command);
                        break;
                    case "Correct":
                        ChangeOldNameNewName(groce, command);
                        break;
                    case "Rearrange":
                        RemoveFromPositionAndAddAtTheEnd(groce, command);
                        break;
                }
                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(", ", groce));

        }

        static List<string> AddItemAtStart(List<string> groce, List<string> command)
        {
            if (!groce.Contains(command[1]))
            {
                groce.Insert(0, command[1]);
                //groce.RemoveAt(1);
            }
            //Console.WriteLine(string.Join(", ", groce));

            return groce;
        }

        static List<string> RemoveItem(List<string> groce, List<string> command)
        {
            if (groce.Contains(command[1]))
            {
                groce.Remove(command[1]);
            }
            //Console.WriteLine(string.Join(", ", groce));

            return groce;
        }

        static List<string> ChangeOldNameNewName(List<string> groce, List<string> command)
        {
            if (groce.Contains(command[1]))
            {
                int index = groce.IndexOf(command[1]);
                groce.Remove(command[1]);
                groce.Insert(index, command[2]);
            }
            //Console.WriteLine(string.Join(", ", groce));

            return groce;
        }

        static List<string> RemoveFromPositionAndAddAtTheEnd(List<string> groce, List<string> command)
        {
            if (groce.Contains(command[1]))
            {
                groce.Remove(command[1]);
                groce.Add(command[1]);
            }
            //Console.WriteLine(string.Join(", ", groce));

            return groce;
        }

    }
}

