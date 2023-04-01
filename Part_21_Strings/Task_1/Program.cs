namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string[] args = Console.ReadLine().Split();
            int system_base = int.Parse(args[0]);
            int number = int.Parse(args[1]);
            string converted = "";
            while (number != 0)
            {
                converted = (number % system_base) + converted;
                number /= system_base;
            }
            Console.WriteLine(converted);
        }
    }
}