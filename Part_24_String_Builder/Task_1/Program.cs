using System.Text;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            String[] command = Console.ReadLine().Split();

            if (command[0] == "Append")
            {
                sb.Append(command[1]);
            }
            else if (command[0] == "Insert")
            {
                int pos = int.Parse(command[1]);
                String newString = command[2];
                sb.Insert(pos, " " + newString);
            }
            else if (command[0] == "Remove")
            {
                int pos = int.Parse(command[1]);
                int length = int.Parse(command[2]);
                sb.Remove(pos, length + 1);
            }
            else if (command[0] == "Replace")
            {
                String oldString = command[1];
                String newString = command[2];
                sb.Replace(oldString, newString);
            }
            else
            {
                Console.WriteLine("Invalid command");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}