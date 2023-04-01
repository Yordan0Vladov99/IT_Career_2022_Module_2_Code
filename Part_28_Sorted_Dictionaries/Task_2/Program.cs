using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        var phonebook = new SortedDictionary<string, string>();

        while (command != "END")
        {
            if (command == "ListAll")
            {
                foreach (var contact in phonebook)
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }
            }
            else
            {
                string[] argsList = command.Split(' ');
                switch (argsList[0])
                {
                    case "S":
                        string user = argsList[1];
                        if (phonebook.ContainsKey(user))
                        {
                            Console.WriteLine($"{user} -> {phonebook[user]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {user} does not exist.");
                        }
                        break;
                    case "A":
                        string newUser = argsList[1];
                        string number = argsList[2];
                        phonebook[newUser] = number;
                        break;
                    default:
                        Console.WriteLine("Invalid call");
                        break;
                }
            }
            command = Console.ReadLine();
        }
    }
}