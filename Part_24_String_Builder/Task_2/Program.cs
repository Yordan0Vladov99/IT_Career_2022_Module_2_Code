using System.Text;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            String[] girlEmail = Console.ReadLine().Split("@");
            int dif = 0;
            foreach (char c in girlEmail[0])
            {
                dif += c;
            }
            foreach (char c in girlEmail[1])
            {
                dif -= c;
            }
            Console.WriteLine(dif >= 0 ? "Call her!" : "She is not the one.");


        }
    }
}