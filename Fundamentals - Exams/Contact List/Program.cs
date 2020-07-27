using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Contact_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Print")
            {
                switch (command[0])
                {
                    case "Add":
                        int index = int.Parse(command[2]);
                        string contact = command[1];

                        if (contacts.Contains(contact) && IfInexIsValid(index, contacts))
                        {
                            contacts.Insert(index, contact);

                        }
                        else if (!contacts.Contains(contact))
                        {
                            contacts.Add(contact);
                        }
                        break;

                    case "Remove":
                        index = int.Parse(command[1]);
                        if (IfInexIsValid(index, contacts))
                        {
                            contacts.RemoveAt(index);
                        }
                        break;

                    case "Export":
                        int startIndex = int.Parse(command[1]);
                        int count = int.Parse(command[2]);
                        List<string> export = new List<string>();
                        if (count >= contacts.Count || count <= 0)
                        {
                            count = contacts.Count;
                        }
                        for (int i = startIndex; i <= startIndex + count - 1; i++)
                        {
                            if (i < contacts.Count)
                            {
                                export.Add(contacts[i]);
                            }

                        }
                        Console.WriteLine(string.Join(" ", export));
                        break;
                }
                command = Console.ReadLine().Split();
            }
            if (command[1] == "Normal")
            {
                Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
            }
            if (command[1] == "Reversed")
            {
                contacts.Reverse();
                Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
            }
        }

        static bool IfInexIsValid(int index, List<string> contacts)
        {
            if (index >= 0 && index < contacts.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
