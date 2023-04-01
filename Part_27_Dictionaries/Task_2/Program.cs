using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        while (command != "END")
        {
            string[] cmdArgs = command.Split(' ');
            switch (cmdArgs[0])
            {
                case "S":
                    if (phonebook.ContainsKey(cmdArgs[1]))
                    {
                        Console.WriteLine("{0} -> {1}", cmdArgs[1], phonebook[cmdArgs[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", cmdArgs[1]);
                    }
                    break;
                case "A":
                    phonebook[cmdArgs[1]] = cmdArgs[2];
                    break;
                default:
                    Console.WriteLine("Invalid call");
                    break;
            }
            command = Console.ReadLine();
        }
    }
}
